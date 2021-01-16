using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.EgitmenAdi = "EnginDemirog";
            kurs1.IzlenmeOrani = 68;
            kurs1.KursAdi = "C#";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.EgitmenAdi = "Kerem Varis";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.EgitmenAdi = "Berkay Bilgin";
            kurs3.KursAdi = "Python";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.EgitmenAdi = "Murat Kurtbogan";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.EgitmenAdi);
            Kurs[] kurslar = new Kurs[]
            {
                kurs1, kurs2, kurs3, kurs4
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.EgitmenAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string EgitmenAdi { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
