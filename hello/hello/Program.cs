using System;

namespace Hello
{
    class Program
    //mivel ez a Program nevű class a Hello namespace-ben van, ezért ez igazából Hello.Program
    {
        static void Main(string[] args)
        // az 'args' miatt be tud veni külön dolgokat, mint ahogy lejjebb van a ReadLine-al
        // ezek a beadott argumentumok oda lesznek adva a main metódusnak
        // --> tehát a main method kaphat args nevű tömbbe értékeket (lejjebb ez a név és az óra, amit megadunk)
        {
            Console.WriteLine("your name?");
            string name = Console.ReadLine();

            Console.WriteLine("how many hours of sleep did you get last night");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name);

            if (hoursOfSleep > 8)
            {
                Console.WriteLine("you are well rested");
            }
            else
                Console.WriteLine("you need more sleep");
            
        }
    }
}
