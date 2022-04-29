using System;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZAR ATMA UYGULAMASI");
            AnaEkran:
            Console.WriteLine("Zar Atma > ZAR AT");
            Console.WriteLine("Uygulamayı Kapatma > KAPAT");
            string option = Console.ReadLine();
            if (option== "ZAR AT")
            {
                ZarAtma:
                Console.WriteLine("Tek Zar Atma > TEK ZAR");
                Console.WriteLine("Çift Zar Atma > ÇİFT ZAR");
                Console.WriteLine("Ana Ekrana Dönme > Ana Ekran");
                string option2 = Console.ReadLine();

                if (option2 == "TEK ZAR")
                {
                    TekZar();
                    goto ZarAtma;

                }
                else if(option2=="ÇİFT ZAR")
                {
                    ÇiftZar();
                    goto ZarAtma;
                }
                else if (option =="ANA EKRAN")
                {
                    goto AnaEkran;
                }
                else
                {
                    Console.WriteLine("Lütfen bir seçenek seçiniz!");
                    goto ZarAtma;
                }
            }
            else if (option=="KAPAT")
            {
                goto bitiş;
            }
            else
            {
                Console.WriteLine("Lütfen bir seçenek seçiniz!");
                goto AnaEkran;
            }
           bitiş:
            Console.WriteLine();
        }
        public  static void TekZar()
        {
            Random Bir = new Random();
            int Tek = Bir.Next(1, 6);
            Console.WriteLine("Gelen Sayı: {0}",Tek);
        }
        public static void ÇiftZar()
        {
            Random İki = new Random();
            int Çift1 = İki.Next(1, 6);
            int Çift2 = İki.Next(1, 6);
            Console.WriteLine("Gelen Sayılar: {0}-{1}",Çift1,Çift2);
        }
    }
}
