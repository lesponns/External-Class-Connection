using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_32_15_08_23_
{
    internal class Method
    {
        public int ToplamaIslemi(int[] sayilar)
        {
            int toplam = 0;
            foreach (int i in sayilar) 
            {
                toplam += i;
            }
            return toplam;
        }
        public void ToplamiveOrtalamayiYazdir(int tplm, int adet)
        {
            int avarage;
            avarage = tplm / adet;
            Console.Write("\n Sayıların Toplamı: {0}\nSayıların Ortalaması: ",tplm,avarage);
        }
    }
}
