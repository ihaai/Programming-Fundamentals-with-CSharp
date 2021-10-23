using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var valueSequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = 0;
            var val = 0;

            while (valueSequence.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    val = valueSequence[0];
                    result += val;
                    valueSequence[0] = valueSequence[valueSequence.Count - 1];
                }
                else if (index > valueSequence.Count - 1)
                {
                    val = valueSequence[valueSequence.Count - 1];
                    result += val;
                    valueSequence[valueSequence.Count - 1] = valueSequence[0];
                }
                else
                {
                    val = valueSequence[index];
                    result += val;
                    valueSequence.RemoveAt(index);
                }

                for (int i = 0; i < valueSequence.Count; i++)
                {
                    if (valueSequence[i] <= val)
                    {
                        valueSequence[i] += val;
                    }
                    else
                    {
                        valueSequence[i] -= val;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
