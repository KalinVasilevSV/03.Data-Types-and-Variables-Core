using System;

namespace _17.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type double is better than float
            //Float causes anomalies due to insufficient precision

            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            float eps = 0.000001f;
            bool areEqual = false;

            //Math.Round() works as good as the Convert approach
            //Both of the methods can't compate very small numbers with opposite sign but work fine with the same sign

            //firstNum = (float)Math.Round(firstNum, 6);
            //secondNum = (float)Math.Round(secondNum, 6);

            //firstNum = (float)Convert.ToDouble($"{Convert.ToString(firstNum):0.000000}");
            //secondNum = (float)Convert.ToDouble($"{Convert.ToString(secondNum):0.000000}");

            //areEqual=(firstNum==secondNum);

            double difference = Math.Abs(firstNum - secondNum);
            if (difference < eps) areEqual = true;

            Console.WriteLine(areEqual);
        }
    }
}
