using System;

namespace flowcharts
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            Console.WriteLine("Skriv ett tal mellan 1 och 100");
            int atal = int.Parse(Console.ReadLine());
            int lotteri = slump.Next(1, 101);
            int X = 1;
            while (atal != lotteri)
            {
                if (atal < lotteri)
                {
                    Console.WriteLine("Din gissning var för låg, skriv en ny gissning");
                    atal = int.Parse(Console.ReadLine());
                    X = X + 1;
                }
                else
                {
                    Console.WriteLine("Din gissning var för hög, skriv en ny gissning");
                    atal = int.Parse(Console.ReadLine());
                    X = X + 1;
                }
            }
            Console.WriteLine("Du gissade rätt på " + X + " försök");



        }
    }
}
