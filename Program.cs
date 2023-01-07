using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static int ObebBul(int sayi1, int sayi2)
        {
            while (sayi1 != sayi2)
            {
                if (sayi1 > sayi2)
                {
                    sayi1 = sayi1 - sayi2;
                }
                    
                
                if (sayi2 > sayi1)
                {
                    sayi2 = sayi2 - sayi1;
                }
                    
            }
            return sayi1;
        }
        
        static int OkekBul(int sayi1, int sayi2)
        {
            return (sayi1 * sayi2) / ObebBul(sayi1, sayi2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Obeb ve Okek Hesaplama Programı");
            Console.Write("Birinci Sayı: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sayı: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int obeb = ObebBul(a, b);
            int okek = OkekBul(a, b);
            Console.WriteLine("OBEB({0,4},{1,4}) = {2,6}", a, b, obeb);
            Console.WriteLine("OKEK({0,4},{1,4}) = {2,6}", a, b, okek);
            Console.ReadKey();
        }
    }
}