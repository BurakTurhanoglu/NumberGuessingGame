using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** SAYI BULMA OYUNU ********** ");
            Console.WriteLine("Bilgisayar, belleğinde 1'den 20'ye kadar rastgele bir rakam tuttuktan sonra oyuncu o sayıyı tahmin etmeye çalışacaktır.");
            Console.WriteLine("Toplamda 5 tahmin hakkınız vardır.");
            int sayi, hak = 5;
            bool kosul = false;
            int[] dizi = new int[6];
            Random rnd = new Random();
            int randomsayi = rnd.Next(0, 20);
            Console.WriteLine("*********************");
            for (int i=1; i<dizi.Length; i++)
            {
                Console.WriteLine("{0}. tahmininiz. ", i);
                Console.WriteLine("Sayıyı giriniz: ");
                sayi = int.Parse(Console.ReadLine());
                if (sayi > 20)
                {
                    Console.Write("1 ile 20 arasında bir sayı giriniz.");
                    break;
                }
                if (sayi == randomsayi)
                {
                    Console.Write("Tebrikler!");
                        kosul = true;
                    break;
                }
                if (!kosul)
                {
                    Console.WriteLine("Tekrar deneyiniz. ");
                }
            }
            Console.Read();
        }
    }
}
