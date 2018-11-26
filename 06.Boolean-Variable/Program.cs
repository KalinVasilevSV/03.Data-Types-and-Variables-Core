using System;

namespace _06.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();

            bool ifTrue = Convert.ToBoolean(value);

            if (ifTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
