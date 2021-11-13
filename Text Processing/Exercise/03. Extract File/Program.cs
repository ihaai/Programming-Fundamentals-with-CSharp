using System;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] location = Console.ReadLine().Split(@"\");
            string[] infoSplit = location[^1].Split(".");
            string fileName = infoSplit[0];
            string fileExtension = infoSplit[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
