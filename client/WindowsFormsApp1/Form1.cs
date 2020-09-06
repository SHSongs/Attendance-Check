using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Text.RegularExpressions;


namespace WindowsFormsApp1
{
  

  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string data = InputAC.Text;


            Computer computer = new Computer(data);


            //학년선택
            int gradeNum = 0;

            if(grade1.Checked)
            {
                gradeNum = 0;
            }
            else if (grade2.Checked)
            {
                gradeNum = 1;
            }
            else if (grade3.Checked)
            {
                gradeNum = 2;
            }


            //반선택
            int roomNum = 0;
            if(room1.Checked)
            {
                roomNum = 0;
            }
            else if(room2.Checked)
            {
                roomNum = 1;
            }
            else if (room3.Checked)
            {
                roomNum = 2;
            }
            else if (room4.Checked)
            {
                roomNum = 3;
            }

            if(allclass.Checked)
            {
                roomNum = 10;
            }


            //번호선택
            Student stu = Student.all;

            if(allStudent.Checked)
            {
                stu = Student.all;
            }
            else if (frontStudent.Checked)
            {
                stu = Student.front;
            }
            else if (backStudent.Checked)
            {
                stu = Student.back;
            }


            List<string> ls = computer.출첵_안한분_찾아내기(gradeNum,roomNum, stu);

            richTextBox1.Text = "";
            foreach(string s in ls)
            {

                richTextBox1.Text += s+"\n";
            }

            if(ls.Count == 0)
            {
                richTextBox1.Text = "없음";
            }
             
            notattenNum.Text = ls.Count.ToString() + " 명";

            return;
        }

    
    }
    public enum Student
    {
        all = 0,
        front,
        back
    }

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


        public Computer(string data)
        {
            OriginalData = data;

            Class00Str = "";
            Class01Str = "";
            Class02Str = "";
            Class03Str = "";

            Class10Str = "";
            Class11Str = "";
            Class12Str = "";
            Class13Str = "";

            List<string> grade0Str = new List<string>() { Class00Str, Class01Str, Class02Str, Class03Str };
            List<string> grade1Str = new List<string>() { Class10Str, Class11Str, Class12Str, Class13Str };



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
            else if (slit_data[0].Contains("댓글"))
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


        public List<string> 출첵_안한분_찾아내기(int grade, int room, Student stu)
        {
           

            List<string> data = 날짜지우기();
            
            List<string> 안한분 = new List<string>();
            List<string> name = new List<string>();

            if (room == 10) // AllClass
            {
                foreach(List<string> ls in AttendanceList[grade])
                {
                    name.AddRange(ls);
                }
                
            }
            else
            {

                int harf = AttendanceList[grade][room].Count / 2;
                int end = AttendanceList[grade][room].Count;

                switch (stu)
                {
                    case Student.all:
                        name = AttendanceList[grade][room];
                        break;
                    case Student.front:
                        name = AttendanceList[grade][room].GetRange(0, harf);
                        break;
                    case Student.back:
                        name = AttendanceList[grade][room].GetRange(harf, end - harf);
                        break;
                }
            }


            for (int i = 0; i < name.Count; i++)
            {
                bool check = false;
                for (int j = 0; j < data.Count; j++)
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
