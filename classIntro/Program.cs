using System;

namespace classIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "Pyhton";
            kurs1.Egitmeni = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "kerem";
            kurs2.IzlenmeOrani = 125;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "C#";
            kurs3.Egitmeni = "berkcan";
            kurs3.IzlenmeOrani = 512;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs3.Egitmeni);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3, };

            foreach (var kurs in kurslar) ;
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);
            }
        }         
    }

    class kurs
    {
        public string KursAdi  { get; set; }

        public string Egitmeni { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
