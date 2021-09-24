using System;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
			int number = int.Parse(Console.ReadLine());
			for (int i = 2; i <= number; i++)
			{
				bool isPrime = true;
				for (int nCheck = 2; nCheck < i; nCheck++)
				{
					if (i % nCheck == 0)
					{
						isPrime = false;
						break;
					}
				}
				Console.WriteLine($"{i} -> {Convert.ToString(isPrime).ToLower()}");
			}
		}
    }
}
