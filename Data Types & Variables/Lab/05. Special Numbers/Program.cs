using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			int sum = 0;
			int num = 0;
			bool ok = false;
			for (int i = 1; i <= n; i++)
			{
				num = i;
				while (num != 0)
				{
					sum += (num % 10);
					num = num / 10;
				}
				if (sum == 5 || sum == 7 | sum == 11)
				{
					ok = true;
					Console.WriteLine($"{i} -> {ok}");
					sum = 0;
				}
				else
				{
					ok = false;
					Console.WriteLine($"{i} -> {ok}");
					sum = 0;
				}
			}
		}
    }
}
