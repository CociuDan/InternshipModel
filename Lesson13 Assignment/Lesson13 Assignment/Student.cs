using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Assignment
{
    public class Student
    {
        public Student(int age, double averageMark, List<string> courses, string faculty, string group, string name)
        {
            Age = age;
            AverageMark = averageMark;
            Courses = courses;
            Faculty = faculty;
            Group = group;
            Name = name;
        }

        public int Age { get; set; }
        public double AverageMark { get; set; }
        public List<string> Courses { get; set; }
        public string Faculty { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
    }
}
