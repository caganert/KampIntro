﻿using System;

namespace Loops 
{

    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array - dizi

            string[] kurslar = new string[]
            {
              "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python"
            };

            for (int i = 0; i<kurslar.Length; i++) //i++ (1 arttırır)   i=i+n veya i+=n (n kadar arttırır)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("-----------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
