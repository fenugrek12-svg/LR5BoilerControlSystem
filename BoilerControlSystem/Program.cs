using System;
using System.Threading;

namespace BoilerControlSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var boiler = new Boiler();

            for (int i = 1; i <= 10; i++)
            {
                boiler.SimulateIteration(i);
                Thread.Sleep(800);
            }
        }
    }
}