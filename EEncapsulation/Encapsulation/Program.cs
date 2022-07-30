using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            Console.WriteLine(sample.yas);

            Key key = new Key();
            key.Test();
            Console.WriteLine(key.yas);

        }
    }

    public class Sample
    {
        public int yas = 52;
        protected string ad = "Barbara";
        private string soyAd = "Liskov";
    }

    public class Key : Sample
    {
        /*
         yas değişkeni public olduğu için erişim sağlanabilir
         ad değişkeni protected olduğu için türetilmiş class'tan erişim sağlanabilir
         soyAd değişkeni private olduğu için  erişim sağlanamaz
         */
        public void Test()
        {
            yas = 40;
            ad = "Michele";
        }
    }
}
