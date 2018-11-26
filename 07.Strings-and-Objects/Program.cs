using System;

namespace _07.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            object hello = Console.ReadLine();
            object world = Console.ReadLine();

            string greeting = (string)hello +" "+(string)world;

            Console.WriteLine(greeting);
        }
    }
}
