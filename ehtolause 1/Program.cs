using System;
static void LukujenJarjestys(Console console)
{
    string kluku1, kluku2;
    int luku1, luku2;
    console.WriteLine("Ohjelma pyytää sinulta kahta kokonaislukua ja tulostaa ne suuruusjärjestyksessä.");
    Console.Write("Anna luku 1.");
    kluku1 = Console.ReadLine();
    Console.Write("Anna luku 2.");
    kluku2 = Console.ReadLine();
    try
    {
        luku1 = Int32.Parse(kluku1);
        luku2 = Int32.Parse(kluku2);
    }