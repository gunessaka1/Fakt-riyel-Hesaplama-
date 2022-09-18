using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi  ;
          int  faktoriyel=1;
            int i;
            Console.Write("sayıyı giriniz :");
            sayi = Convert.ToInt16(Console.ReadLine());
            while (  1 <= sayi)
            {
                faktoriyel = faktoriyel * sayi;
                sayi--;
            }
            Console.WriteLine(faktoriyel);
            Console.Read();
        }
    }
}
