using System;

namespace Delegare_1
{
    public delegate void Temsilci(int p);
    class Program
    {
        public delegate void Del(int p);

        public static void Foo(int f)
        {
            Console.WriteLine("Foo:"+f);
        }

        public static void Bar(int b)
        {
            Console.WriteLine("Bar:" + b);
        }

        public static void Zet(int z)
        {
            Console.WriteLine("Zet:" + z);
        }

        static void Main(string[] args)
        {
            
            Del del = new Del(Foo); //Del(void(int) target) => geri dönüş değeri olamayan ve herhangi bir int parametresi olan bir fonksiyonu temsil edebilir


            del += new Del(Bar);
            del += new Del(Zet);

            del(45);//Fonksiyonu dolaylı yoldan çağrılması
                    //del.Invoke(2);

            del -= new Del(Zet);

            Delegate[] delegateList = del.GetInvocationList();

            foreach (var item in delegateList)
            {
                Console.WriteLine(item.Method.Name);
            }
        }
    }
}
