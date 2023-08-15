using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_32_15_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adet, toplam;

            Console.Write("Sayı adedi: ");
            adet = int.Parse(Console.ReadLine());

            int[] numbers = new int[adet];

            for (int i = 0; i < adet; i++) 
            {
                Console.Clear();
                Console.Write("\n{0}. Sayı: ", (i + 1));
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\n");
            Method hesaplama = new Method();

            toplam = hesaplama.ToplamaIslemi(numbers);

            hesaplama.ToplamiveOrtalamayiYazdir(toplam,numbers.Length);

            Console.ReadKey();
        }
    }
}
