using System;
using System.Collections.Generic;
using System.Linq;

using System.Text.RegularExpressions;

namespace TestProject1
{
    class Computer
    {
        
        public readonly string OriginalData;
        
        
        public readonly string Class00Str;
        public readonly string Class01Str;
        public readonly string Class02Str;
        public readonly string Class03Str;
        
        public readonly string Class10Str;
        public readonly string Class11Str;
        public readonly string Class12Str;
        public readonly string Class13Str;
        
        
        public readonly List<List<List<string>>> AttendanceList = new List<List<List<string>>>();
        
        
        public Computer()
        {
            OriginalData =
                "";

            Class00Str = "";
            Class01Str = "";
            Class02Str = "";
            Class03Str = "";

            Class10Str = "";
            Class11Str = "";
            Class12Str = "";
            Class13Str = "";

            List<string> grade0Str = new List<string>() {Class00Str, Class01Str, Class02Str, Class03Str};
            List<string> grade1Str = new List<string>() {Class10Str, Class11Str, Class12Str, Class13Str};
            
            

            AttendanceList.Add(new List<List<string>>());
            AttendanceList.Add(new List<List<string>>());
            foreach (var names in grade0Str)
            {
                AttendanceList[0].Add(new List<string>(new List<string>(names.Split(','))));
            }
            foreach (var names in grade1Str)
            {
                AttendanceList[1].Add(new List<string>(new List<string>(names.Split(','))));
            }
        }

        public List<string> 기본처리()
        {
            List<string> slit_data = new List<string>(OriginalData.Split('\n'));

            slit_data = slit_data.Where(x => x != "").ToList();

            Regex regex = new Regex(@"[0-9]{1}개$");

            if (regex.IsMatch(slit_data[0]))
            {
                slit_data.RemoveAt(0);
            }
            

            return slit_data;
        }

        public List<string> 내용삭제()
        {
            List<string> data = 기본처리();

            for (int i = 0; i < data.Count; i++)
            {
                if (i % 2 == 1)
                {
                    data[i] = "";
                }    
            }
            data = data.Where(x => x != "").ToList();

            // var enumerable = Enumerable.Range(1, data.Count).Select(x =>
            // {
            //     data.RemoveAt(x);
            //     return x;
            // });


            return data;

        }

        public List<string> 날짜지우기()
        {
            List<string> data = 내용삭제();




            for (int i = 0; i < data.Count; i++)
            {

                int c = data[i].IndexOf("오전");

                if (c == -1)
                {
                    c = data[i].IndexOf("오후");

                    if (c == -1)
                    {
                        c = data[i].IndexOf("월");
                        string month = DateTime.Now.ToString("MM");

                        if (Int32.Parse(month) >= 10)
                        {
                            c -= 2;
                        }
                        else
                        {
                            c -= 1;
                        }
                    }
                }


                data[i] = data[i].Substring(0, c);
            }

            return data;
        }


        public List<string> 출첵_안한분_찾아내기(int grade, int room)
        {
            List<string> data = 날짜지우기();
            List<string> name = AttendanceList[grade][room];
            
            List<string> 안한분 = new List<string>();
            
            for (int i = 0; i < name.Count; i++)
            {
                bool check = false;
                for(int j = 0; j < data.Count; j++)
                {
                    if (name[i] == data[j])
                    {
                        check = true;
                        break;
                    }
                }

                if (check == false)
                {
                    안한분.Add(name[i]);
                }
            
            }
            

            return 안한분;
        }
        
    }
}