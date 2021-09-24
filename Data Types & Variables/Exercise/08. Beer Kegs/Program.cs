using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> VC = new List<double>();
            List<string> BK = new List<string>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string kegModel = Console.ReadLine();
                float kegRadius = float.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double V = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;
                VC.Add(V);
                BK.Add(kegModel);
            }

            int biggest = VC.IndexOf(VC.Max());
            Console.WriteLine(BK[biggest]);
        }
    }
}
