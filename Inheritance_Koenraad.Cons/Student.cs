using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Koenraad.Cons
{
    internal class Student : Person
    {
        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void GoToSchool()
        {
            Console.WriteLine($"{FirstName} gaat naar school.");
        }

        public string GetAge()
        {
            return $"{FirstName} is {Age} jaar oud.";
        }
    }
}
