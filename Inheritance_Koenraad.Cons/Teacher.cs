using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Koenraad.Cons
{
    internal class Teacher : Person
    {
        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public List<string> Courses { get; set; }

        public void Instruct(string subject)
        {
            Console.WriteLine($"Ik leg even {subject} uit.");
        }
    }
}
