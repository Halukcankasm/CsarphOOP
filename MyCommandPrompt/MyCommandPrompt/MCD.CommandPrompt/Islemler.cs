using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MCD.CommandPrompt
{
    public class Islemler
    {
        public void EkranıTemizle()
        {
            Console.Clear();
            Console.WriteLine("======= FreeHCS Started =======");
            Console.Beep();
        }

        public void AktifKullanici()
        {
            Console.WriteLine("Aktif kullanıcı: " + Environment.UserName);
        }

        public void IcerikGoster(string path)
        {
            string[] files = Directory.GetFiles(path);

            if (files.Length > 0)
            {
                foreach (var item in files)
                {
                    Console.WriteLine(">> "+item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Files is empty or null");
            }
        }
    }
}
