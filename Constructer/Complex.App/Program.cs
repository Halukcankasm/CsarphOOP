using ComplexNum;
using System;

namespace Complex.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ComplexNumber c1 = new ComplexNumber(3, 5);
            ComplexNumber c2 = new ComplexNumber(1, 5);

            ComplexNumber.Add(c1, c2);

            //---Random Complex---//
            ComplexNumber c3 = new ComplexNumber();
            ComplexNumber c4 = new ComplexNumber();
            ComplexNumber.Add(c3, c4);



        }
    }
}
