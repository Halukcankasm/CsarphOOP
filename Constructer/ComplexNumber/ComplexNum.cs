using System;

namespace ComplexNumber
{
    public class ComplexNum
    {
        public readonly int reel;
        public readonly int imajiner;

        public ComplexNum(int reel, int imajiner)
        {
            this.reel = reel;
            this.imajiner = imajiner;
        }

        public string Add(ComplexNum c1, ComplexNum c2)
        {
            int reel = c1.reel + c2.imajiner;
            int imajinel = c1.imajiner + c2.imajiner;

            return $"{reel}i + {imajiner}j";
        }
    }
}
