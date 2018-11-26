using System;

namespace _12.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = int.Parse(Console.ReadLine());
            float hours = int.Parse(Console.ReadLine());
            float minutes=int.Parse(Console.ReadLine());
            float seconds = int.Parse(Console.ReadLine());

            float mps = distanceInMeters / (hours*3600+minutes*60+seconds);
            float kph = (distanceInMeters / 1000) / (hours + minutes / 60 + seconds / 3600);
            float mph = kph * 0.621510059f;

            Console.WriteLine(mps);
            Console.WriteLine(kph);
            Console.WriteLine(mph);

        }
    }
}
