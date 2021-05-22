using System.Collections.Generic;

namespace AttendanceCheck
{
    class SchoolService
    {
        private readonly List<string> _grade0Str;
        private readonly List<string> _grade1Str;
        private readonly School _school;

        public SchoolService()
        {
            var class00Str = "";
            var class01Str = "";
            var class02Str = "";
            var class03Str = "";

            var class10Str = "";
            var class11Str = "";
            var class12Str = "";
            var class13Str = "";

            _grade0Str = new List<string>() {class00Str, class01Str, class02Str, class03Str};
            _grade1Str = new List<string>() {class10Str, class11Str, class12Str, class13Str};

            _school = new School();
        }

        public void SetupSchool()
        {
            for (GradeEnum i = 0; i <= GradeEnum.Grade2; i++)
            {
                int count = 0;
                foreach (var names in GetStudent(i))
                {
                    _school.Grades[(int) i].Classes[count].SetStudents(new List<string>(names.Split('\t')));
                    count++;
                }
            }
        }

        public List<string> GetStudent(GradeEnum gradeEnum)
        {
            if (gradeEnum == GradeEnum.Grade1)
            {
                return _grade0Str;
            }
            else if (gradeEnum == GradeEnum.Grade2)
            {
                return _grade1Str;
            }
            else if (gradeEnum == GradeEnum.Grade3)
            {
                return null;
            }

            return null;
        }

        public List<Student> ReturnStudent(int grade, int room, AttendanceMathod attendanceMathod)
        {
            List<Student> checkStudents = new List<Student>();


            if (room == 10) // AllClass
            {
                foreach (Class c in _school.Grades[grade].Classes)
                {
                    checkStudents.AddRange(c.Students);
                }
            }
            else
            {
                int harf = _school.Grades[grade].Classes[room].Students.Count / 2;
                int end = _school.Grades[grade].Classes[room].Students.Count;

                switch (attendanceMathod)
                {
                    case AttendanceMathod.all:
                        checkStudents = _school.Grades[grade].Classes[room].Students;
                        break;
                    case AttendanceMathod.front:
                        checkStudents = _school.Grades[grade].Classes[room].Students.GetRange(0, harf);
                        break;
                    case AttendanceMathod.back:
                        checkStudents = _school.Grades[grade].Classes[room].Students.GetRange(harf, end - harf);
                        break;
                }
            }

            return checkStudents;
        }
    }

    class School
    {
        public List<Grade> Grades;

        public School()
        {
            Grades = new List<Grade>();

            for (int i = 0; i < 3; i++)
            {
                Grades.Add(new Grade());
            }
        }
    }

    class Grade
    {
        public List<Class> Classes;

        public Grade()
        {
            Classes = new List<Class>();
            for (int i = 0; i < 4; i++)
            {
                Classes.Add(new Class());
            }
        }
    }

    class Class
    {
        public List<Student> Students;

        public Class()
        {
            Students = new List<Student>();
        }

        public void SetStudents(List<string> studentNames)
        {
            foreach (var name in studentNames)
            {
                Students.Add(new Student(name));
            }
        }
    }

    class Student
    {
        public string Name;

        public Student(string name)
        {
            this.Name = name;
        }
    }

    public enum AttendanceMathod
    {
        all = 0,
        front,
        back
    }
}