using System;

namespace _01._Data_Types
{
    class Program
    {
        static void DataType(string type, string value)
        {
            if (type == "int")
            {
                Console.WriteLine(int.Parse(value) * 2);
            }
            else if (type == "real")
            {
                Console.WriteLine($"{double.Parse(value) * 1.5:F2}");
            }
            else
            {
                value = String.Format("${0}$", value);
                Console.WriteLine(value);
            }
        }

        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            string value = Console.ReadLine();
            DataType(data, value);
        }
    }
}
