using System;

namespace ProfilingLibtraryRandomUA
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 10000000; i++)
            {
                var rand = RandomUserAgent.RandomUa.RandomUserAgent;
                Console.WriteLine(rand);
            }
        }
    }
}