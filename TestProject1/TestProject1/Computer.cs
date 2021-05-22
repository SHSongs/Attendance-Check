using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AttendanceCheck
{
    public enum GradeEnum
    {
        Grade1,
        Grade2,
        Grade3,
        Error
    }

    public enum Platform
    {
        Google,
        Ebs
    }

    class Computer
    {
        private readonly string _originalData;

        private SchoolService schoolService;
        
        public Computer(string data)
        {
            _originalData = data;
            schoolService = new SchoolService();
            schoolService.SetupSchool();
        }

        public List<string> RemoveBlank(Platform platform)
        {
            List<string> slitData = new List<string>(_originalData.Split('\n'));


            if (platform == Platform.Ebs)
            {
                int tmp = 0;


                if (Int32.TryParse(slitData[slitData.Count - 1], out tmp))
                {
                    slitData[slitData.Count - 1] = "";
                }

                slitData = slitData.Where(x => x != "ㄴ ").ToList();
            }


            slitData = slitData.Where(x => x != "").ToList();

            Regex regex = new Regex(@"[0-9]{1}개");

            if (regex.IsMatch(slitData[0]))
            {
                slitData.RemoveAt(0);
            }

            return slitData;
        }

        public List<string> RemoveNote(List<string> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (i % 2 == 1)
                {
                    data[i] = "";
                }
            }

            data = data.Where(x => x != "").ToList();

            return data;
        }

        public List<string> RemoveDate(List<string> data, Platform platform)
        {
            if (platform == Platform.Google)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    int c = data[i].IndexOf("오전", StringComparison.Ordinal);

                    if (c == -1)
                    {
                        c = data[i].IndexOf("오후", StringComparison.Ordinal);

                        if (c == -1)
                        {
                            c = data[i].IndexOf("월", StringComparison.Ordinal);
                            string month = DateTime.Now.ToString("MM");

                            if (Int32.Parse(month) >= 10)
                                c -= 2;
                            else
                                c -= 1;
                        }
                    }

                    data[i] = data[i].Substring(0, c);


                    Regex r = new Regex("[0-9]");

                    bool bSkypassNoChk = r.IsMatch(data[i]);

                    if (bSkypassNoChk)
                    {
                        data[i] = data[i].Substring(4, data[i].Length - 4);
                    }

                    data[i] = data[i].Trim();
                }
            }
            else if (platform == Platform.Ebs)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    Regex r = new Regex("[0-9]{4}-[0-9]{2}-[0-9]{2}|[0-9]{4}.[0-9]{2}.[0-9]{2}");

                    if (r.IsMatch(data[i]))
                    {
                        data[i] = "";
                    }
                }

                data = data.Where(x => x != "").ToList();
            }


            return data;
        }

        public List<string> 이름지우기(List<string> data)
        {
            Regex r = new Regex("^[가-힣]{1}.{1}[가-힣]{1}$");


            for (int i = 0; i < data.Count; i++)
            {
                if (r.IsMatch(data[i]))
                {
                    data[i] = "";
                }
            }

            data = data.Where(x => x != "").ToList();

            return data;
        }

        public List<string> 내용에서_이름만살리기(List<string> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                Regex r = new Regex("[0-9]");

                bool bSkypassNoChk = r.IsMatch(data[i]);

                if (bSkypassNoChk)
                {
                    data[i] = data[i].Substring(4, data[i].Length - 4);
                }

                int c = data[i].IndexOf("출석", StringComparison.Ordinal);
                data[i] = data[i].Substring(0, c);

                data[i] = data[i].Trim();
            }


            return data;
        }

        public List<string> GetData(Platform platform)
        {
            if (platform == Platform.Google)
            {
                return RemoveDate(RemoveNote(RemoveBlank(platform)), platform);
            }
            else if (platform == Platform.Ebs)
            {
                return 내용에서_이름만살리기(이름지우기(RemoveDate(RemoveBlank(platform), platform)));
            }

            return null;
        }

        private Result Analyze(List<Student> students, List<string> datas, Platform platform)
        {
            List<string> 안한분 = new List<string>();


            foreach (var t1 in students)
            {
                var check = datas.Any(t => t1.Name == t);

                if (check == false)
                {
                    안한분.Add(t1.Name);
                }
            }


            List<int> notfoundIdx = new List<int>();

            for (int i = 0; i < datas.Count; i++)
            {
                var check = students.Any(s => s.Name == datas[i]);

                if (check)
                {
                    datas[i] = "";
                }
            }

            for (int i = 0; i < datas.Count; i++)
            {
                if (datas[i] != "")
                {
                    notfoundIdx.Add(i);
                }
            }

            List<string> notdifinename = new List<string>();

            if (platform == Platform.Ebs)
            {
                List<string> note = 이름지우기(RemoveDate(RemoveBlank(platform), platform));

                foreach (int idx in notfoundIdx)
                {
                    notdifinename.Add(note[idx]);
                }
            }


            return new Result(안한분, notdifinename);
        }

        public Result FindPeopleDidNotCheckAttendance(int grade, int room, Platform platform, AttendanceMathod attendanceMathod)
        {
            List<string> data = GetData(platform);

            List<Student> checkStudents = schoolService.ReturnStudent(grade, room, attendanceMathod);

            Result result = Analyze(checkStudents, data, platform);

            return result;
        }
    }

    public class Result
    {
        public List<string> 안한분;
        public List<string> 미분류;

        public Result(List<string> 안한분, List<string> note)
        {
            this.안한분 = 안한분;
            this.미분류 = note;
        }
    }
}