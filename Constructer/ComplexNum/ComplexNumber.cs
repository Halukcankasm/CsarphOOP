using System;

namespace ComplexNum
{
    public class ComplexNumber
    {
        public int Reel { get; }
        public int Imajinel { get; }

        public ComplexNumber(int reel, int imajinel)
        {
            Reel = reel;
            Imajinel = imajinel;
        }

        public static String Add(ComplexNumber c1, ComplexNumber c2)
        {
            Console.WriteLine($"{c1.Reel + c2.Reel}i + {c2.Imajinel + c2.Imajinel}j");
            return $"{c1.Reel+c2.Reel}i + {c2.Imajinel+c2.Imajinel}j";
        }


    }
}
