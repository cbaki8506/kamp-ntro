using System;

namespace kampİntro
{
    internal class Program
    {
        static void Main(string[] args)
            //do not repeat yourself
        {
            string kategoriEtiketi = ("kategoriler");
            Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun=7.35;
            double dolarBugun = 7.45;

            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else if (dolarDun> dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmisMi ==true)
            {
                Console.WriteLine("kullanici Ayarlari Butonu");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yap Butonu");
            }

            
        }
    }
}
