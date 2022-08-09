using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MCD.CommandPrompt
{
    public delegate void Islem();
    public delegate void ParametrikIslem(string parametre);
    public class KomutIstemi
    {
        private Hashtable hshTable = null;
        private Islemler islemler = null;

        public KomutIstemi()
        {
            hshTable = new Hashtable(3);
            islemler = new Islemler();

            hshTable.Add("clr", new Islem(islemler.EkranıTemizle));
            hshTable.Add("who", new Islem(islemler.AktifKullanici));
            hshTable.Add("ls", new ParametrikIslem(islemler.IcerikGoster));
        }

        public void Calistir(string komut)
        {
            string[] comment = komut.Split(' ');
            string komutIfadesi =  comment[0];
            string path;
            if (comment.Length == 2)
            {
                path = comment[1];
            }
            else
            {
                path = null;
            }

            if (hshTable.ContainsKey(komutIfadesi))
            {
                if (path == null)
                {
                    if (komutIfadesi != "ls")
                    {
                        ((Islem)hshTable[komutIfadesi]).Invoke();
                    }
                }
                else
                {
                    ((ParametrikIslem)hshTable[komutIfadesi]).Invoke(path);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Girilen Kod bulunamamıştır");
                Console.ResetColor();
            }
        }





    }
}
