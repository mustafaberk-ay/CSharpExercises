using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip guveligi
            //Do not repeat yourself - Kendini tekrarlama

            //Deger tutucu, alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 320000000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis oku");
            }
            else
            {
                Console.WriteLine("Degismedi oku");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
