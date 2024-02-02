using System;
using System.Collections.Generic;
 namespace inlämnings_uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> land = new Dictionary<string,int>();
            land["Finland"] = 338;
            land["Sverige"] = 528;
            land["Norge"] = 385;
            land["Danmark"] = 43;
            land["finland"] = 338;
            land["sverige"] = 528;
            land["norge"] = 385;
            land["danmark"] = 43;
            Console.WriteLine("Skriv in ett land i skandinavien som du vill veta storleken på");
            string svar = Console.ReadLine();
            Console.WriteLine($"{svar}  Är {land[svar]} 000 km²");
            Console.ReadKey();
        }
    }
}