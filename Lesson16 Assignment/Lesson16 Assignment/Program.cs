using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(Add(1, 2, 3, 4, 5));
            ReadKey();
            WriteLine(ShowStudent("Dan", 22));
            ReadKey();
            WriteLine(ShowStudent(age: 22, name: "Cociu"));
            ReadKey();



            dynamic something = new List<string>
            {
                "cociu dan",
                "brega alla",
                "botnari andrei"
            };
            var group = "TI-131";
            foreach (dynamic item in something)
            {
                WriteLine($"{item.ToUpper()} {group.ToLower()}");
            }
            ReadKey();






            int a = 2147483647;
            long b = a;




        }

        


        public static int Add(params int[] param)
        {
            int amount = 0;
            foreach(int i in param)
            {
                amount += i;
            }
            return amount;
        }

        public static string ShowStudent(string name, int age = 0)
        {
            if (age > 0)
                return $"{name} - {age}";
            return $"{name}";
        }


    }
}
