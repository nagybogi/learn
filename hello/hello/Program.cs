//csinál egy name space-t
//ettől a programunk neve igazából nem is 'Program', hanem
//hello.Program
using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
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
