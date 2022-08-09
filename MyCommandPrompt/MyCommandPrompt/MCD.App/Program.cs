using MCD.CommandPrompt;
using System;

namespace MCD.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler islemler = new Islemler();
            islemler.EkranıTemizle();

            KomutIstemi komutIstemi = new KomutIstemi();


            while (true)
            {
                var komut = Console.ReadLine();
                komutIstemi.Calistir(komut);
            }
        }
    }
}
