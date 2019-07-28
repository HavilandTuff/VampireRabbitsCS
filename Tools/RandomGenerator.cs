using System;
using VampireRabbitsCS;
namespace VampireRabbitsCS
{
    public static class RandomNumberGenerator
    {
        private static readonly Random _simpleGenerator = new Random();
        public static int SimpleRandomNumber( int minValue, int maxValue)
        {
            return _simpleGenerator.Next(minValue, maxValue+1);
        }

    }
}
