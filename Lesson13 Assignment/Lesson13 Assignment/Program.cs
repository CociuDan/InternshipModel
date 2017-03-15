using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Assignment
{
    class Program
    {
        delegate void MethodInvoker();

        static void Main(string[] args)
        {
            #region Courses Lists
            List<string> developerCourses = new List<string>()
            {
                "Programare Calculatoarelor",
                "Sisteme de Operare",
                "Programarea Web",
                "Asamblarea si Depanarea PC",
                "Baze de date"
            };

            List<string> statisticsCourses = new List<string>()
            {
                "Econometrie",
                "Statistica",
                "Microeconomie",
                "Teoria Sistemelor",
                "Macroeconomie"
            };

            List<string> journalismCourses = new List<string>()
            {
                "Arta Vorbirii",
                "Discursul Public",
                "Comunicare",
                "Relatii cu Publicul",
                "Managementul Resurselor Umane"
            };

            List<string> internationRelationsCourses = new List<string>()
            {
                "Microeconomie",
                "Macroeconomie"
            };
            #endregion

            Student justStudent = new Student(21, 10, journalismCourses, "FJSC", "JC-131", "Zatic Carina");
            Student justStudent2 = new Student(20, 9.9, journalismCourses, "FJSC", "JC-131", "Cociu Victoria");

            #region Students Lists
            List<Student> students = new List<Student>()
            {
                new Student(22, 9.0, developerCourses, "CSIE", "TI-131", "Cociu Dan"),
                new Student(21, 8.5, developerCourses, "CSIE", "TI-131", "Brega Alla"),
                new Student(22, 8.2, statisticsCourses, "CSIE", "SPE-131", "Turcanu Diana"),
                new Student(24, 7.0, developerCourses, "CSIE", "TI-131", "Mescinschi Valeriu"),
                justStudent,
                justStudent,
                justStudent2
            };

            List<Student> students2 = new List<Student>()
            {
                new Student(22, 8.8, internationRelationsCourses, "REI", "IR-121", "Costin Daria"),
                justStudent,
                justStudent2
            };
            #endregion

            Console.WriteLine("Students under 24");
            foreach (var student in students.Where(x => x.Age < 24))
            {
                Console.WriteLine($"\t{student.Age} - {student.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Taking first 3 students");
            foreach (var student in students.Take(3))

            {
                Console.WriteLine($"\t{student.Age} - {student.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();


            Console.WriteLine("Taking first students that are under 24");
            foreach (var student in students.TakeWhile(x => x.Age < 24))
            {
                Console.WriteLine($"\t{student.Age} - {student.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Skiping 2 students");
            foreach (var student in students.Skip(2))
            {
                Console.WriteLine($"\t{student.Age} - {student.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Skiping first students that are under 23");
            foreach (var student in students.SkipWhile(x => x.Age < 23))
            {
                Console.WriteLine($"\t{student.Age} - {student.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Distinct students");
            foreach (var student in students.Distinct())
            {
                Console.WriteLine($"\t{student.Age} - {student.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Students Name & Faculty");
            foreach (var student in students.Select(x => x.Name + " - " + x.Group))
            {
                Console.WriteLine($"\t{student}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Courses");
            foreach (var student in students.SelectMany(x => x.Courses).Distinct())
            {
                Console.WriteLine($"\t{student}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Joining 2 lists of students");
            foreach (var student in students.Join(students2, s1 => s1.Faculty,
                                                   s2 => s2.Faculty,
                                                   (s1, s2) => new { Name = s1.Name, Course = s2.Faculty }))
            {
                Console.WriteLine($"\t{student}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Group Joining 2 lists of students");
            foreach (var student in students.GroupJoin(students2, s1 => s1.Faculty,
                                                   s2 => s2.Faculty,
                                                   (s1, s2) => new { Name = s1.Name, s1.Faculty }))
            {
                Console.WriteLine($"\t{student}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Ziping 2 lists of students");
            foreach (var student in students.Zip(students2, (s1, s2) => s1.Name + " - " + s2.Name))
            {
                Console.WriteLine($"\t{student}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Sutdents Ordered by Name");
            foreach (var student in students.OrderBy(x => x.Name))
            {
                Console.WriteLine($"\t{student.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Sutdents Ordered by Name then by Age");
            foreach (var student in students.OrderBy(x => x.Name).ThenBy(x => x.Age))
            {
                Console.WriteLine($"\t{student.Name} - {student.Age}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Sutdents Ordered by Name descending");
            foreach (var student in students.OrderByDescending(x => x.Name))
            {
                Console.WriteLine($"\t{student.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Sutdents Ordered by Name then by Age descending");
            foreach (var student in students.OrderByDescending(x => x.Name).ThenBy(x => x.Age))
            {
                Console.WriteLine($"\t{student.Name} - {student.Age}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();


            students.Reverse();
            Console.WriteLine("Sutdents in Reverse order");
            foreach (var student in students)
            {
                Console.WriteLine($"\t{student.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();
            students.Reverse();



            Console.WriteLine("Students grouped by Group");
            foreach (var student in students.GroupBy(x => x.Group))
            {
                Console.WriteLine($"\t{student.Key}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("2 Lists of students concatenated");
            foreach (var student in students.Concat(students2))
            {
                Console.WriteLine($"\t{student.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("2 Lists of students in union");
            foreach (var student in students.Union(students2))
            {
                Console.WriteLine($"\t{student.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Students that are in both lists");
            foreach (var student in students.Intersect(students2))
            {
                Console.WriteLine($"\t{student.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Students that are in first list but not in the second one");
            foreach (var student in students.Except(students2))
            {
                Console.WriteLine($"\t{student.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Dictionary of students");
            foreach (var student in students2.ToDictionary((x => x.AverageMark), (x => x.Name)))
            {
                Console.WriteLine($"\t{student}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Lookup of students");
            foreach (var student in students.ToLookup((x => x.Group), (x => x.Name)))
            {
                Console.WriteLine($"\t{student.Key}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Student[] studentsArray = students.ToArray();
            Console.WriteLine("Students in Array");
            for (int i = 0; i < studentsArray.Length; i++)
            {
                Console.WriteLine($"\t{studentsArray[i].Name} - {studentsArray[i].AverageMark}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("First students that is 22 years old");
            Console.WriteLine($"\t {students.First(x => x.Age == 22).Name}");
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("First students that is 23 years old or default value");
            Console.WriteLine($"\t{students.FirstOrDefault(x => x.Age == 23)}");
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();

            Console.WriteLine("Last students that is 22 years old");
            Console.WriteLine($"\t{students.Last(x => x.Age == 22).Name}");
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();



            Console.WriteLine("Last students that is 23 years old");
            Console.WriteLine($"\t{students.LastOrDefault(x => x.Age == 23)}");
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();

            //Lookup<int, int> l = new Lookup<int, int>();

            //Console.WriteLine("Single students that is 22 years old");
            //Console.WriteLine($"{students.Single(x => x.Age == 22).Name}");
            //Console.WriteLine("-----------------------------------");
            //Console.ReadKey();



            Console.WriteLine("Checks if lists contains this object");
            if (students.Contains(justStudent))
            {
                Console.WriteLine($"\t{justStudent.Name}");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();







            MethodInvoker[] delegates = new MethodInvoker[2];

            int outVar = 1;

            for (int i = 0; i < 2; i++)
            {
                int inVar = 1;
                Console.WriteLine(inVar);
                delegates[i] = delegate
                {
                    Console.WriteLine($"({outVar}, {inVar})");
                    outVar++;
                    inVar++;
                };
            }
            MethodInvoker first = delegates[0];
            MethodInvoker second = delegates[1];

            first();
            first();
            first();

            second();
            second();
            second();
            Console.ReadKey();
            Console.WriteLine("-----------------------------------");






















        //List<Action> delegatesList = new List<Action>();
        //foreach(var i in Enumerable.Range(0, 5))
        //{
        //    delegatesList.Add(() => Console.WriteLine($"{i} {outOfForVar}"));
        //    outOfForVar++;
        //}
        //foreach(var ceva in delegatesList)
        //{
        //    ceva();
        //}
        //Console.ReadKey();





        //List<MethodInvoker> delegates = new List<MethodInvoker>();
        //int outOfForVar = 1;
        //for (int i = 0; i < 3; i++)
        //{
        //    delegates.Add(
        //        delegate
        //        {
        //            Console.WriteLine($"({outOfForVar}, {i})");
        //            outOfForVar += i;
        //            i += outOfForVar;
        //        }
        //        );
        //}



        //foreach(var ceva in delegates)
        //{
        //    ceva();
        //}
        //Console.ReadKey();


    }
}
}
