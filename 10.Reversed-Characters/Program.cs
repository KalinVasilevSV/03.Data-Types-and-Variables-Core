using System;

namespace _10.Reversed_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            object one = Console.ReadLine();
            object two = Console.ReadLine();
            object three = Console.ReadLine();

            string reversed = (string)three + (string)two + (string)one;

            Console.WriteLine(reversed);
        }
    }
}
