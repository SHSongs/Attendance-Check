using System.Collections.Generic;

namespace TestProject1
{
    class SchoolService
    {
        private List<string> grade0Str;
        private List<string> grade1Str;
        
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
            
            grade0Str = new List<string>() {class00Str, class01Str, class02Str, class03Str};
            grade1Str = new List<string>() {class10Str, class11Str, class12Str, class13Str};
        }

        public List<string>  GetStudent(GradeEnum gradeEnum)
        {
            if (gradeEnum == GradeEnum.Grade1)
            {
                return grade0Str;
            }
            else if (gradeEnum == GradeEnum.Grade2)
            {
                return grade1Str;
            }
            else if (gradeEnum == GradeEnum.Grade3)
            {
                return null;
            }
            else
            {
                return null;
            }
        }
    }

    class School
    {
        public List<Grade> Grades;

        public School()
        {
            Grades = new List<Grade>();
            
            for(int i = 0; i < 3; i++)
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
            for(int i = 0; i < 4; i++)
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

}