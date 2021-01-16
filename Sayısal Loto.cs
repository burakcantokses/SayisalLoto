using System;

namespace C_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[7];
            int sayi;
            int[] randomSayilar = new int[7];

            for (int i = 0; i < 7; i++){
                System.Console.WriteLine("{0}. Sayınızı Girin.",i+1);
                sayi = Convert.ToInt16(Console.ReadLine());

                while (Array.IndexOf(sayilar,sayi) > -1)
                {
                    System.Console.WriteLine("Lütfen Girdiğiniz Sayıyı Bir Daha Girmeyin.");
                    sayi = Convert.ToInt16(Console.ReadLine());                    
                }
                sayilar[i] = sayi;
            }
            System.Console.WriteLine("Sayılar Çekiliyor..");
            Random random = new Random();
            int bilinen = 0;
            for (int i = 0; i < 7; i++)
            {
                randomSayilar[i] = random.Next(1,47);
                if (Array.IndexOf(randomSayilar,sayilar) > -1) {
                    System.Console.WriteLine("{0}. Sayınız Aynı Çıktı Tebrikler!",i+1);
                    bilinen = bilinen+1;
                }else {
                    System.Console.WriteLine("{0}. Sayınız Farklı Çıktı. Çıkan Sonuç: {1}", i+1,randomSayilar[i]);
                }
            }
            System.Console.WriteLine("Toplam {0} tane sayi bildin", bilinen);
        }
    }
}