using System;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var time = new TimeSpan(0, 3, 0);
            System.Console.WriteLine(time.Ticks);

            System.Console.ReadLine();
        }
    }
}
