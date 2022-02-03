using System;

namespace odev6_03._02._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = {"product1", "product2","product3"} ;

            product product1 = new product();
            product1.Markasi = "Philips";
            product1.EkranBoyutu = 40;
            product1.Fiyati = 7999.99;

            product product2 = new product();
            product2.Markasi = "LG";
            product2.EkranBoyutu = 42;
            product2.Fiyati = 8499.99;

            product product3 = new product();
            product3.Markasi = "Samsung";
            product3.EkranBoyutu = 49;
            product3.Fiyati = 11599.99;

            //product [] products = new product[] { product1, product2, product3 };
            
            foreach (var product in products)
            {
                //Console.WriteLine (product.Markasi + ":" +product.Fiyati); 
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(products[i]);
            }
            
        }
    }
    class product
    {
        public string Markasi { get; set; }
        public int EkranBoyutu { get; set; }
        public double Fiyati { get; set; }
    }
}
