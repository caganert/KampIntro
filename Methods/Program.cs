using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };


            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Explanation = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            //type-safe -- tip güvenliği
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("------------------------");
            }

        }
    }
}


//Don't repeat yourself - DRY - Clean Code - Best Practice