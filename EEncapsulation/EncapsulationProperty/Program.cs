using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "jack";
            student1.SurName = "Racher";
            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.SurName);
            Console.WriteLine(student1.IDNumber);
            Console.WriteLine(student1.EmailAddress);
        }
    }
}
