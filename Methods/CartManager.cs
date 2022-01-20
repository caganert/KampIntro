using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CartManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi : " + product.Name);
        }

        // public void Add2(string productName, string explanation, double price, int stockQuantity)
        // {
        //     Console.WriteLine("Sepete eklendi : " + productName);
        // }
    }
}
