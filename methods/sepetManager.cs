using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class sepetManager
    {
        public void Ekle(product product)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi :"+product.Name);

        }
        public void Ekle2(string Name, string Explanation, double Price, int Stock)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi :" + Name);
        }

    }
}
