using System;

namespace _15.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int inDecimal = int.Parse(Console.ReadLine());

            string hex = Convert.ToString(inDecimal, 16).ToUpper();
            string binary = Convert.ToString(inDecimal, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
