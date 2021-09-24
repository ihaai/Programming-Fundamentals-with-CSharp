using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowBalls = int.Parse(Console.ReadLine());
            BigInteger snowBallValue = 0;
            BigInteger snowBallSnow = 0;
            BigInteger snowBallTime = 0;
            BigInteger betSnowBall = int.MinValue;
            int snowBallQuality = 0;
            string bestFormula = null;

            for (int i = 0; i < snowBalls; i++)
            {
                snowBallSnow = BigInteger.Parse(Console.ReadLine());
                snowBallTime = BigInteger.Parse(Console.ReadLine());
                snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger val = snowBallSnow / snowBallTime;
                snowBallValue = BigInteger.Pow(val, snowBallQuality);

                if (snowBallValue > betSnowBall)
                {
                    betSnowBall = snowBallValue;
                    bestFormula = $"{snowBallSnow} : {snowBallTime} = {snowBallValue} ({snowBallQuality})";

                }
            }

            Console.WriteLine(bestFormula);
        }
    }
}
