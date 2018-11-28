using System;

namespace _18.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startSymbol = int.Parse(Console.ReadLine());
            int endSymbol = int.Parse(Console.ReadLine());

            for (int i = startSymbol; i <= endSymbol; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
