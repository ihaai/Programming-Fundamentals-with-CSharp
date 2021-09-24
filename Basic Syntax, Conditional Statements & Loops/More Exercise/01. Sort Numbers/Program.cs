using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());
			int[] arr = new int[3];
			arr[0] = num1;
			arr[1] = num2;
			arr[2] = num3;
			Array.Sort(arr);
			Array.Reverse(arr);
			foreach (var i in arr)
			{
				Console.WriteLine(i);
			}
		}
    }
}
