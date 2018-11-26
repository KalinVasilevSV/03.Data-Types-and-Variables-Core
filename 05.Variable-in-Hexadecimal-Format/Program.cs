using System;

namespace _05.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();

            int inDecimal=Convert.ToInt32(hex,16);

            Console.WriteLine(inDecimal);
        }
    }
}
