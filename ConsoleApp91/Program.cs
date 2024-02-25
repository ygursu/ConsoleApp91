using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedenkenarlarigirilendikdortgenincevresi
{
    class Program
    {
        static void Main(string[] args)
        {

            int kisakenar, uzunkenar, cevre;

            Console.WriteLine("Lütfen dikdörtgenin kısa kenarını giriniz");
            kisakenar = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen dikdörtgenin uzun kenarını giriniz");
            uzunkenar = Int32.Parse(Console.ReadLine());

            cevre = kisakenar + uzunkenar + kisakenar + uzunkenar;

            Console.WriteLine("Dikdörtgenin çevresi={0}", cevre);
            Console.ReadLine();

        }
    }
}