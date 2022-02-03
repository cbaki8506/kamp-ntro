using System;

namespace methods
{
    internal class Program
    {
        private static object product1;
        private static object product3;
        private static object product2;

        static void Main(string[] args)
        {
            



            product product1 = new product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya Elması";
            product1.stockAdeti = 12;

            product product2 = new product();
            product2.Name = "Çilek";
            product2.Price = 21;
            product2.Explanation = "Kayabaşı Çileği";
            product2.stockAdeti = 15;

            product product3 = new product();
            product3.Name = "Karpuz";
            product3.Price = 80;
            product3.Explanation = "Diyarbakır Karpuzu";
            product3.stockAdeti = 16;
            product[] products = new product[] { product1, product2, product3, };

            foreach (var product in products)

            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine(product.stockAdeti);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("--------Methods-----------"); 

            sepetManager SepetManager = new sepetManager();
            SepetManager.Ekle(product1);
            SepetManager.Ekle(product2);
            SepetManager.Ekle(product3);

            SepetManager.Ekle2 ("Armut", "Yeşil Armut", 14,10);
            SepetManager.Ekle2("elma", "Yeşil Elma", 12,10);
            SepetManager.Ekle2("Karpuz", "Adana Karpuzu", 5,12);




        }
    }
}
