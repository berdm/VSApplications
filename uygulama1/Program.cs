using System;

namespace uygulama1
{
    class Program
    {
        static int MaxDeger = int.MaxValue;
        static double dMaxDeger = double.MaxValue;
        static float fMaxDeger = float.MaxValue;
        static decimal deMaxDeger = decimal.MaxValue;
        static long lMaxDeger = long.MaxValue;
        static byte bMaxDeger = byte.MaxValue;
        static void Main(string[] args)
        {
            //switch-case yapısı
            //girilen bir sayini karesi küpü

            int sayi;
            int secim;

            Console.WriteLine("lutfen bir sayi giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("1-girilen sayinin karesini al.");
            Console.Write("\n2 - girilen sayinin küpünü al.");
            secim = Convert.ToInt32(Console.ReadLine());

            switch(secim)
            {
                case 1:
                    Console.WriteLine("\n girilen sayinin karesi :" + sayi * sayi);
                    break;
                case 2:
                    Console.WriteLine("\n girilen sayinin küpü:" + sayi * sayi * sayi);
                    break;
                default:
                    Console.WriteLine("yanlıs secim oldu");
                    break;
            }

            /*
            //if-else kullanimi
            // kullanıcıdan alınan sayının tek-cift oldugunu belirlemek

            int sayi;
            Console.Write("lutfen bir sayi giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            // hem ikiye hem uce bolunebilme
             if (sayi %2 ==0 && sayi %3 ==0)
            {
                Console.WriteLine("girdiginiz sayi 2 ve 3'e bolunebilen sayidir");
            }
            else 
            {
                Console.WriteLine("girdiginiz sayi 2 ve 3'e bolunebilen bir sayi degildir");
            }
            */
            /*
             if (sayi %2 == 0)
            {
                Console.WriteLine("girdiğiniz sayi 2'ye bolunebilen bir sayidir.");
            }
             else if (sayi %3 == 0)
            {
                Console.WriteLine("girdiginiz sayi 3'e bolunebilen bir sayidir.");
            }
             else
            {
                Console.WriteLine("girdiginiz sayi 2 ya da 3 e bolunebilen bir sayı degildir");
            }
            */

            /*
            //yazdırmak icin iki yol vardır ikinci yol daha cok tercıh edilir.
            Console.WriteLine("Integer veri tipinin Max degeri: {0}", MaxDeger);
            Console.Write("Integer veri tipinin Max degeri:" + MaxDeger);

            //diger veri tipleri icin max degerler
            Console.WriteLine("double veri tipinin Max degeri:" + dMaxDeger);
            Console.WriteLine("float veri tipinin Max degeri:" + fMaxDeger);
            Console.WriteLine("decimalveri tipinin Max degeri:" + deMaxDeger);
            Console.WriteLine("long veri tipinin Max degeri:" + lMaxDeger);
            Console.WriteLine("byte veri tipinin Max degeri:" + bMaxDeger);

            Console.WriteLine("\n\n\n");
            */
            /*
            //degiskenler
            // kullanicidan alinan iki sayi toplami
            int birinciSayi;
            int ikinciSayi;
            int toplam;
            //toint kullanmamızın nedeni integer kullanmamaız double kullansaydık
            //todouble yazardik
            Console.Write("Birinci sayiyi giriniz:");
            birinciSayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayiyi giriniz:");
            ikinciSayi = Convert.ToInt32(Console.ReadLine());

            toplam = birinciSayi + ikinciSayi;
            Console.WriteLine("islem sonucu" + toplam);

            Console.WriteLine("\n\n\n");
            */
            /*
            //operator kullanımı 
            int hesapla = 3 * 5 / 7; ;
            Console.WriteLine(hesapla);

            //bu sayıların double oldugunu belirtmek icin ya ondalıgını verırız ya da
            // sayının sonuna d koyaırz 3.0 = 3d gibi
            double hesaplaa = 3.0 * (5.0 / 7.0);
            Console.WriteLine(hesaplaa);

            int kalan = 10 % 3;
            Console.WriteLine(kalan);

            int a = 10;
            int b = a++; //  once a nın degerini b ye yaz sonra a yı bir arttır a=11 b=10
            int c = b--; // c=10 b=9
            int d = --c; //d=9 c=9
            int e = 7;
            int f = e / 2; // f=3 int oldugu ıcın tam sayıs kısmını alır
            // a+b+c+d+e+f
            //11+9+9+9+7+3=48

            Console.WriteLine(a + b + c + d + e + f);

            */


            Console.ReadKey();
        }
    }
}
