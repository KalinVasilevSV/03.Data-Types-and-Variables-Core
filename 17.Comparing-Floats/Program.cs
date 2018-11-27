using System;

namespace _17.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNum = float.Parse(Console.ReadLine());
            float secondNum = float.Parse(Console.ReadLine());

            float eps = 0.000001f;

            //firstNum = (float)Math.Round(firstNum, 6);
            //secondNum = (float)Math.Round(secondNum, 6);

            //Math.Round() works as good as the Convert approach

            firstNum = (float)Convert.ToDouble($"{Convert.ToString(firstNum):0.000000}");
            secondNum = (float)Convert.ToDouble($"{Convert.ToString(secondNum):0.000000}");

            Console.WriteLine(firstNum==secondNum);
        }
    }
}
