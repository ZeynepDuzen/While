using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** kullanicidan alinan 5 degerin toplamini hesaplayin ***
            //int sayiAdedi = 1;
            //int toplam = 0;

            //while (sayiAdedi<=5)
            //{
            //    Console.WriteLine(sayiAdedi + " .sayiyi giriniz : ");
            //    int gelenSayi = Convert.ToInt32(Console.ReadLine());
            //    toplam = toplam + gelenSayi;
            //    sayiAdedi++;
            //    Console.WriteLine("Girilen sayilarin toplami : " + toplam); // her satırda toplami yazdirir
            //}
            //Console.WriteLine("Girilen sayilarin toplami : " + toplam); --> toplami bir kez yazdirir

            // *** matematikte bulunan 9 rakamın toplamini while ile hesaplayin
            //int sayi = 1;
            //int toplam = 0;

            //while (sayi <= 9)
            //{
            //    Console.WriteLine(sayi + " .sayiyi giriniz : ");
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    toplam = toplam + input;
            //    sayi++;
            //    Console.WriteLine("Toplam : " + toplam);

            //}
            //Console.WriteLine("Toplam : " + toplam);

            // *** 1' den 100' e kadar olan sayilari ekranda for ile yazın

            int i;
            for (i=1; i<=100; i++)
            {
                Console.WriteLine(i + ",");
            }
            Console.WriteLine();
            // *** 1 - 100 arasi cift sayilari ekrana yazdirin
            for (i=2; i<= 100; i = i+2)
            {
                Console.WriteLine(i + ",");
            }
            //2.yol --> cift sayilar
            for (i = 0; i <= 100; i++)
            {
                if (i % 2 == 0 )
                {
                    Console.WriteLine(i + ",");
                }
            }
            
        }
    }
}
