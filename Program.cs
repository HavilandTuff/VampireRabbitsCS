using System;

namespace VampireRabbitsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Rabbit testRabbit = new Rabbit();
            Console.WriteLine($"New rabbit created with name: {testRabbit.Name}.");
        }
    }
}
