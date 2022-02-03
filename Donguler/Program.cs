using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = ("Yazılım Geliştirici Yetiştirme Kampı");
            string kurs2 = ("Proglamlamaya Başlangıç İçin Temel Kurs");
            string kurs3 = ("Java Kursu");
            string kurs4 = ("Python Kursu");

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            string[] kurslar = { "Yazılım Geliştirici Yetiştirme Kampı", "Proglamlamaya Başlangıç İçin Temel Kurs", "Java Kursu", "Python Kursu" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);    
            }

            foreach (string kurs in kurslar) 
            {
                Console.WriteLine(kurs);
            }
                Console.WriteLine ("Sayfa Sonu - footer");

        } 
    }
}
