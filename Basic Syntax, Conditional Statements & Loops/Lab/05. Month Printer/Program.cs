using System;

namespace _05._Month_Printer
{
    class Program
    {
        static string getAbbreviatedName(int month)
        {
            DateTime date = new DateTime(2020, month, 1);

            return date.ToString("MMMM");
        }

        static void Main(string[] args)
        {
            int mNum = int.Parse(Console.ReadLine());
            switch (mNum)
            {
                case 1: Console.WriteLine(getAbbreviatedName(mNum)); break;
                case 2: Console.WriteLine(getAbbreviatedName(mNum)); break;
                case 3: Console.WriteLine(getAbbreviatedName(mNum)); break;
                case 4: Console.WriteLine(getAbbreviatedName(mNum)); break;
                case 5: Console.WriteLine(getAbbreviatedName(mNum)); break;
                case 6: Console.WriteLine(getAbbreviatedName(mNum)); break;
                case 7: Console.WriteLine(getAbbreviatedName(mNum)); break;
                case 8: Console.WriteLine(getAbbreviatedName(mNum)); break;
                case 9: Console.WriteLine(getAbbreviatedName(mNum)); break;
                case 10: Console.WriteLine(getAbbreviatedName(mNum)); break;
                case 11: Console.WriteLine(getAbbreviatedName(mNum)); break;
                case 12: Console.WriteLine(getAbbreviatedName(mNum)); break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }

        }
    }
}
