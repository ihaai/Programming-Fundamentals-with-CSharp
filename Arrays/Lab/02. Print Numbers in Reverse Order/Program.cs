using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                int arrAdd = int.Parse(Console.ReadLine());
                arr[i] = arrAdd;
            }

            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
