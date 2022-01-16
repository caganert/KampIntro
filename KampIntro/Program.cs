using System;

namespace KampIntro
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //type safety - tip güvenliği
            //Do not repeat yourself - kendini tekrarlama

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 18.50;
            double dolarBugun = 13.50;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azaış Oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
