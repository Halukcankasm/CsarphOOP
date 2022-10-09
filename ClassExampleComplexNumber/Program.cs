using System;

namespace ClassExampleComplexNumber
{
    class Complex
    {
        private readonly int reel;
        private readonly int imajinel;

        public Complex(int reel, int imajinel)
        {
            this.reel = reel;
            this.imajinel = imajinel;
        }


        public Complex Add(Complex p1, Complex p2)
        {
            int r = p1.reel + p2.reel;
            int imj = p1.imajinel + p2.imajinel;

            return new Complex(r, imj);
        }

        public Complex Extraction(Complex p1, Complex p2)
        {
            int r = p1.reel - p2.reel;
            int imj = p1.imajinel - p2.imajinel;

            return new Complex(r, imj);
        }

        public Complex Multiplication(Complex p1, Complex p2)
        {
            int r = (p1.reel * p2.reel) - (p1.imajinel * p2.imajinel);
            int imj = (p1.reel * p2.imajinel) + (p1.imajinel * p2.reel);

            return new Complex(r, imj);
        }
        

        public void Display()
        {
            Console.WriteLine($"{this.reel} + {this.imajinel}j");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(2, 4);

            Complex resultAdd = c1.Add(c1, c2);
            Complex resultExt = c1.Extraction(c1, c2);
            Complex resultMlt = c1.Multiplication(c1, c2);

            resultAdd.Display();
            resultExt.Display();
            resultMlt.Display();
        }
    }
}
