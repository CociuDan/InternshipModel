using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Assignment
{
    public class Student
    {
        public Student(int age, double averageMark, List<string> courses, string faculty, string group, string name)
        {
            Age = age;
            AverageMark = averageMark;
            Courses = courses;
            AtFaculty = faculty;
            Group = group;
            Name = name;
        }
        public int Age { get; set; }
        public double AverageMark { get; set; }
        public List<string> Courses { get; set; }
        public string AtFaculty { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }


        #region Coincidental Cohesion
        public void DriveCar()
        {
            Console.WriteLine("You're driving car");            
        }


        public void DisplayPI()
        {
            Console.WriteLine("3.14");
        }

        public void SetMark()
        {
            Console.WriteLine($"Stundents name: {Name} Mark: {9.5}");
        }
        #endregion

        #region Content Coupling
        Profesor something = new Profesor();
        public void ChangeSalary(int newSalary)
        {
            something.ChangeSalary(newSalary);
        }
        #endregion

        #region Common Coupling
        public Student()
        {
            Faculty.FacultyName = "";
        }
        #endregion







    }
}
