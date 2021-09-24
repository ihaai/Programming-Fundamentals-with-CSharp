using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
			int digit = int.Parse(Console.ReadLine());
			int LD = digit % 10;
			if (LD == 1)
			{
				Console.WriteLine("one");
			}
			else if (LD == 2)
			{
				Console.WriteLine("two");
			}
			else if (LD == 3)
			{
				Console.WriteLine("three");
			}
			else if (LD == 4)
			{
				Console.WriteLine("four");
			}
			else if (LD == 5)
			{
				Console.WriteLine("five");
			}
			else if (LD == 6)
			{
				Console.WriteLine("six");
			}
			else if (LD == 7)
			{
				Console.WriteLine("seven");
			}
			else if (LD == 8)
			{
				Console.WriteLine("eight");
			}
			else if (LD == 9)
			{
				Console.WriteLine("nine");
			}
			else
			{
				Console.WriteLine("zero");
			}
		}
    }
}
