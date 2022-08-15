using System;

namespace SigortaKutusu
{
    public delegate void Del(int deger);
    public class Program
    {
        

        static void Main(string[] args)
        {
            Sigorta sigorta = new Sigorta();

            Del del = new Del(sigorta.AkımKontrol);

            for (int i = 0; i < 40; i++)
            {
                del.Invoke(i);
            }

            
        }
    }
}
