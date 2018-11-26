using System;

namespace _11.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            double centuries = double.Parse(Console.ReadLine());

            double years = centuries * 100;
            double days= (int)(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;
            double seconds = minutes * 60;
            ulong milliseconds = (ulong)seconds * 1000;
            System.Numerics.BigInteger microseconds = milliseconds * 1000;
            System.Numerics.BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
