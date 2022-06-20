using System;

namespace Uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR DÖNGÜSÜ
            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            */
            // 1 den 100 kadar olan sayilarin toplami
            /*
            int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                toplam = toplam + i;
            }
                Console.WriteLine("Sayilarin toplami = {0}", toplam);
            */
            // Kullanicinin girmis oldugu iki sayi arasındaki sayiların toplami
            /*
            int birinciSayi;
            int ikinciSayi;
            int toplam =0;

            Console.WriteLine("birinci sayiyi giriniz:");
            birinciSayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi giriniz:");
            ikinciSayi = Convert.ToInt32(Console.ReadLine());
             
            for (int i = birinciSayi; i<=ikinciSayi; i++)
            {
                toplam = toplam + i;
                //toplam +=i;
            }

            Console.WriteLine("Toplam:" + toplam);
            */

            //Döngü sonunda toplamın kac oldugunu yazdırma satır satır
            /*
            int toplam = 0;
            for( int i=1; i<=100; i++)
            {
                toplam = toplam + i;
                Console.WriteLine("{0}. döngünün sonunda toplam : {1}", i, toplam);
            }
            */

            // WHİLE DONGÜSÜ
            /*
            int a = 1;
            int toplam = 0;
            while(a<=100)
            {
                toplam = toplam + a;
                a++;
                //yazdırma islemini burda yaparsak her döngü sonundaki toplamı yazdırır
                //Console.WriteLine("sayilarin toplami:" + toplam); 
            }
            Console.WriteLine("sayilarin toplami:" + toplam);
            */
            // klavyeden girilen sayi 0 olana kadar girilen sayılardan tek ve çift sayiların toplamını
            //ekrana yazdıma
            /*
            int girilenSayi = 0;
            int tekSayilar = 0;
            int ciftSayilar = 0;

            while(true)
            {
                Console.Write("Sayiyi giriniz:");
                girilenSayi = Convert.ToInt32(Console.ReadLine());

                if (girilenSayi ==0)
                {
                    break;
                }
                if(girilenSayi %2 ==0)
                {
                    ciftSayilar += girilenSayi;
                }
                else
                {
                    tekSayilar += girilenSayi;
                }
            }

            Console.WriteLine("cift sayilarin toplami:" + ciftSayilar);
            Console.WriteLine("tek sayilarin toplami:" + tekSayilar);
            */


            Console.ReadKey();
        }
    }
}
