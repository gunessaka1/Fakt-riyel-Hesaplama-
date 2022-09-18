# Faktoriyel-Hesaplama-
Faktöriyel Hesaplama Döngüler
## Kullanıcıdan alınan sayının faktöriyel hesabını yapalım.
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

![image](https://user-images.githubusercontent.com/98685489/190898013-be94f29a-9aaf-4620-967f-0e39b4bdd871.png)
