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


namespace AttendanceCheck
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


            int gradeNum = ChoiceGrade();
            int roomNum = ChoiceRoom();

            AttendanceMathod stu = ChoiceAttendanceMathod();

            Platform platform = ChoicePlatform();


            Result result = computer.FindPeopleDidNotCheckAttendance(gradeNum,roomNum, platform, stu);

            richTextBox1.Text = "";
            foreach(string s in result.안한분)
            {
                richTextBox1.Text += s+"\n";
            }

            if(result.안한분.Count == 0)
            {
                richTextBox1.Text = "없음";
            }
             
            notattenNum.Text = result.안한분.Count.ToString() + " 명";


            notdifinedname.Text = "";
            foreach (string s in result.미분류)
            {
                notdifinedname.Text += s + "\n";
            }
            return;
        }

        private Platform ChoicePlatform()
        {
            Platform platform = Platform.Google;


            if (Google.Checked)
            {
                platform = Platform.Google;
            }
            else if (Ebs.Checked)
            {
                platform = Platform.Ebs;
            }
            return platform;
        }

        private int ChoiceGrade()
        {
            int gradeNum = 0;

            if (grade1.Checked)
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

            return gradeNum;
        }
        private int ChoiceRoom()
        {
            int roomNum = 0;
            if (room1.Checked)
            {
                roomNum = 0;
            }
            else if (room2.Checked)
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

            if (allclass.Checked)
            {
                roomNum = 10;
            }

            return roomNum;
        }

        private AttendanceMathod ChoiceAttendanceMathod()
        {
            AttendanceMathod stu = AttendanceMathod.all;

            if (allStudent.Checked)
            {
                stu = AttendanceMathod.all;
            }
            else if (frontStudent.Checked)
            {
                stu = AttendanceMathod.front;
            }
            else if (backStudent.Checked)
            {
                stu = AttendanceMathod.back;
            }

            return stu;
        }
    }

}
