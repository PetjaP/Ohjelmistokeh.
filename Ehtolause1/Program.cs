using System;

internal class Program
{
    private static void Main(string[] args)
    {
        static void LukujenJarjestys()
        {
            int luku1, luku2;
            Console.WriteLine("Ohjelma pyytää sinulta kahta kokonaislukua ja tulostaa ne suuruusjärjestyksessä.");
            Console.Write("Anna luku 1: ");
            luku1 = Console.ReadLine();
            Console.Write("Anna luku 2: ");
            luku2 = Console.ReadLine();

            if (luku2 > luku1)
            {
                Console.WriteLine("Lukujen järjestys ", luku1, luku2);
            }
            else
            {
                Console.WriteLine("Lukujen järjestys ", luku2, luku1);
            }

        }
    }
}