using System;

namespace Uygulama2_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //DIZILER

            /*
            string[] isimler = { "fatih","hakan","ali","mustafa"};

            for (int i=0; i<isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            int a = 0;

            while (a < isimler.Length)
            {
                Console.WriteLine(isimler[a]);
                a++;
            }
            */
            /*
            int[] sayilar = new int[5];
            for(int i=0; i<sayilar.Length; i++)
            {
                Console.Write("Dizinin {0}. elemanını giriniz: ", i+1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            */
            /*
            int a = 0;
            
            while(a <sayilar.Length)
            {
               // Console.WriteLine("dizinin {0}. elemanı:", a + 1, sayilar[a]);
                Console.WriteLine("dizinin" + a + "elelmanı:" + sayilar[a]);
                a++;
            }
            */
            //FOREACH KULLANIMI
            /*
            int a = 1;

            foreach(int i in sayilar)
            {
                Console.WriteLine("dizinin" +a+".elemanı:" +i);
                a++;
            }
            */

            //Dizinin en buyuk ve en kucuk elemanını bulan program
            /*
            int[] sayilar = { 10, 20, 30, 5, 1, 2, 3, 8, 9, 120 };
            int enBuyuk = sayilar[0];
            int enKucuk = sayilar[0];

            for (int i=0; i<sayilar.Length; i++)
            {
                if(sayilar[i] >enBuyuk )
                {
                    enBuyuk = sayilar[i];
                }
                if(sayilar[i] < enKucuk)
                {
                    enKucuk = sayilar[i];
                }
            }
            Console.WriteLine("en buyuk sayi:" + enBuyuk);
            Console.WriteLine("en kucuk sayi:" + enKucuk);
            */

            //COK BOYUTLU DIZILER


            // 5 satır ve 2 sütunlu bir dizi

            /*
            int[,] dizi = new int[5, 2] { { 0, 0 },{ 1, 2 },{ 2, 4 },{ 3, 6 },{ 4, 8 } };
            int i, j;

            for (i=0; i<5; i++) // birinci for satırları tarıyor bu nedenle 5 yazdık 5 satır var cunku
            {
                for(j=0; j<2; j++) // sütunları tarıyor ıkıncı for. 2 yazdık cunku iki sütun var
                {
                    Console.WriteLine("a[{0},{1}]={2}", i, j, dizi[i, j]);
                }
            }
            */
            //5*5 lük matris içine sayıları random biz verioyurz ve satır ve sutun daki elelmanların toplamını yazdırma

            int[,] dizi = new int[5, 5];
            Random rnd = new Random();

            for ( int i=0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    dizi[i, j] = rnd.Next(10);
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            for (int m=0; m<5; m++)
            {
                int sutunToplam = 0;
                int satirToplam = 0;

                for(int n=0; n<5; n++)
                {
                    satirToplam += dizi[m, n];
                    sutunToplam += dizi[n, m];
                }

                Console.WriteLine("{0}.satırın toplamı\t: {1}", (m + 1), satirToplam);
                Console.WriteLine("{0}.sutunun toplamı\t: {1}", (m + 1), sutunToplam);
                Console.WriteLine("---------------------");

            }







            Console.ReadKey();
        }
    }
}
