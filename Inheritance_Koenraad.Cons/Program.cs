using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Koenraad.Cons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher("Koenraad", "Pecceu");
            Student s = new Student("Warre", "Pecceu");

            s.GoToSchool();
            t.Instruct("Databankbeheer");

            s.SetAge(18);
            t.SetAge(38);

            Console.WriteLine(s.GetAge());
        }
    }
}
