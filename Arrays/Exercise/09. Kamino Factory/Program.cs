using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLen = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int DNASUM = 0;
            int[] DNA = new int[sequenceLen];
            int DNACOUNT = -1;
            int DNASTARTINDEX = -1;
            int DNASAMPLES = 0;
            int samples = 0;

            while (input != "Clone them!")
            {
                samples++;
                int[] currentDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int currentCount = 0;
                int currentStartIndex = 0;
                int currentEndIndex = 0;
                int currentDNASUM = 0;
                bool isCurrentDNABetter = false;
                int cntr = 0;
                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] != 1)
                    {
                        cntr = 0;
                        continue;
                    }

                    cntr++;
                    if (cntr > currentCount)
                    {
                        currentCount = cntr;
                        currentEndIndex = i;
                    }
                }

                currentStartIndex = currentEndIndex - currentCount + 1;
                currentDNASUM = currentDNA.Sum();

                if (currentCount > DNACOUNT)
                {
                    isCurrentDNABetter = true;
                }
                else if(currentCount == DNACOUNT)
                {
                    if (currentStartIndex < DNASTARTINDEX)
                    {
                        isCurrentDNABetter = true;
                    }
                    else if (currentStartIndex == DNASTARTINDEX)
                    {
                        if (currentDNASUM > DNASUM)
                        {
                            isCurrentDNABetter = true;
                        }
                    }
                }

                if (isCurrentDNABetter)
                {
                    DNA = currentDNA;
                    DNACOUNT = currentCount;
                    DNASTARTINDEX = currentStartIndex;
                    DNASUM = currentDNASUM;
                    DNASAMPLES = samples;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {DNASAMPLES} with sum: {DNASUM}.");
            Console.WriteLine(string.Join(" ", DNA));
        }
    }
}
