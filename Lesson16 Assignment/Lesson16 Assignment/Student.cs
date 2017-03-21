using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Assignment
{
    class Student
    {
        Dictionary<string, string> Groups = new Dictionary<string, string>()
        {
            ["TI"] = "Developers",
            ["BA"] = "Administrators"
            
        };
        public string FirstName { get; }
        public string LastName { get; }
        public double AverageMark { get; }
        public string Group { get; }
        public string StudentNameAndGroup => $"{FirstName} {LastName} - {Group}";


    }

}
