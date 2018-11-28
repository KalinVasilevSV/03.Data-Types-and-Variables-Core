using System;

namespace _20.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int picsTaken = int.Parse(Console.ReadLine());
            int filterTimePic = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTimeSec = int.Parse(Console.ReadLine());

            long goodPics = (long)Math.Ceiling((double)picsTaken * ((double)filterFactor / 100));

            ulong totalTimeSec =(ulong)((goodPics * uploadTimeSec)+(picsTaken*filterTimePic)); // It breaks down here due to type choice

            ulong timeToAllocateSec;

            ulong dd = totalTimeSec / (60*60*24);
            timeToAllocateSec = totalTimeSec % (60 * 60 * 24);
            ulong hh = timeToAllocateSec / (60 * 60);
            timeToAllocateSec = timeToAllocateSec % (60 * 60);
            ulong mm = timeToAllocateSec / 60;
            ulong ss = timeToAllocateSec % 60;

            Console.WriteLine($"{dd}:{hh:00}:{mm:00}:{ss:D2}"); // The interpolated string formattings do the same using different syntax, they add leading zeroes
        }

    }
}
