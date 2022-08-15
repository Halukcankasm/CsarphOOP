using System;
using System.Collections.Generic;
using System.Text;

namespace SigortaKutusu
{
    public class Sigorta
    {
        #region Veri Elemanları/Property
        //State(Durum bilgisi) Özellikleri
        private int anmaAkimi;

        private int AnmaAkımı
        {
            get
            {
                return anmaAkimi;
            }
            set
            {
                anmaAkimi = value;
            }
        }

        public int Akim
        {
            get
            {
                return 20;
            }
        }
        #endregion

        public void AkımKontrol(int _anmaAkimi)
        {
            if (_anmaAkimi > Akim)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("Sigorta Attı: "+ _anmaAkimi);
                Console.ResetColor();

            }
            else
            {
                Console.WriteLine("Anlık akımı değeri standart: "+ _anmaAkimi);
            }
        }
    }
}
