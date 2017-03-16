using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> justAlist = GetStudents();

            justAlist = FilterStudents(justAlist, "Filter criteria");
            justAlist = OrderStudents(justAlist);
            DisplayStudents(justAlist);

            Student s = new Student();
            DisplayStudentAverageMark(s);
            DisplayStudentAverageMark(s.Name, s.AverageMark);

            #region Control Coupling

            #endregion
        }

        #region Temporal Cohesion
        public static void PrepareForLesson()
        {
            GetBooks();
            GetCopyBooks();
            GetPen();
            GetPencil();
        }

        private static void GetPencil()
        {
            throw new NotImplementedException();
        }

        private static void GetPen()
        {
            throw new NotImplementedException();
        }

        private static void GetCopyBooks()
        {
            throw new NotImplementedException();
        }

        private static void GetBooks()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Procedural Cohesion
        //Procedural Cohesion
        public static void DoExam()
        {
            CheckIfStudentIsAccepted();
            GiveStudentATicket();
            EvaluateStudent();
            SetMark();
        }

        private static void SetMark()
        {
            throw new NotImplementedException();
        }

        private static void EvaluateStudent()
        {
            throw new NotImplementedException();
        }

        private static void GiveStudentATicket()
        {
            throw new NotImplementedException();
        }

        private static void CheckIfStudentIsAccepted()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Communicational Cohesion
        public static void GetItemByID() { }
        public static void GetItemInPriceRange() { }
        public static void GetItemByModel() { }
        public static void GetItemByManufacturer() { }
        #endregion

        #region Sequential Cohesion
        public static IEnumerable<Student> GetItems() { return new List<Student>(); }

        public static IEnumerable<Student> FilterItems(string criteria) { return GetItems().Where(criteria); }

        public static IEnumerable<Student> OrderItems() { return FilterItems("Just Filter Items").OrderBy(); }

        public static IEnumerable<Student> DisplayItems() { return OrderItems(); }
        #endregion

        #region Functional Cohesion

        public static List<Student> GetStudents() { }

        public static List<Student> FilterStudents(List<Student> list, string criteria) { return list.Where(criteria); }

        public static List<Student> OrderStudents(List<Student> list) { return list.OrderBy(); }

        public static void DisplayStudents(List<Student> list)
        {
            foreach(var student in list)
            {
                Console.WriteLine(student);
            }
        }
        #endregion

        #region Stamp Coupling
        public static void DisplayStudentAverageMark(Student s)
        {
            Console.WriteLine($"Student: {s.Name}");
            Console.WriteLine($"AverageMark: {s.AverageMark}");
        }
        #endregion

        #region Data Coupling
        public static void DisplayStudentAverageMark(string studentName, double averageMark)
        {
            Console.WriteLine($"Student: {studentName}");
            Console.WriteLine($"AverageMark: {averageMark}");
        }
        #endregion
    }
}
