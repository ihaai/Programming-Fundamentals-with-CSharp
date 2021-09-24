using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int clicks = int.Parse(Console.ReadLine());
            string mainMessage = string.Empty;

            for (int i = 0; i < clicks; i++)
            {
                string digit = Console.ReadLine();
                int mainDigit = int.Parse(digit[0].ToString());
                if (mainDigit == 2)
                {
                    if (digit.Length == 1)
                    {
                        mainMessage += (char)97;
                    }
                    else if (digit.Length == 2)
                    {
                        mainMessage += (char)98;
                    }
                    else if (digit.Length == 3)
                    {
                        mainMessage += (char)99;
                    }
                }
                else if (mainDigit == 3)
                {
                    if (digit.Length == 1)
                    {
                        mainMessage += (char)100;
                    }
                    else if (digit.Length == 2)
                    {
                        mainMessage += (char)101;
                    }
                    else if (digit.Length == 3)
                    {
                        mainMessage += (char)102;
                    }
                }
                else if (mainDigit == 4)
                {
                    if (digit.Length == 1)
                    {
                        mainMessage += (char)103;
                    }
                    else if (digit.Length == 2)
                    {
                        mainMessage += (char)104;
                    }
                    else if (digit.Length == 3)
                    {
                        mainMessage += (char)105;
                    }
                }
                else if (mainDigit == 5)
                {
                    if (digit.Length == 1)
                    {
                        mainMessage += (char)106;
                    }
                    else if (digit.Length == 2)
                    {
                        mainMessage += (char)107;
                    }
                    else if (digit.Length == 3)
                    {
                        mainMessage += (char)108;
                    }
                }
                else if (mainDigit == 6)
                {
                    if (digit.Length == 1)
                    {
                        mainMessage += (char)109;
                    }
                    else if (digit.Length == 2)
                    {
                        mainMessage += (char)110;
                    }
                    else if (digit.Length == 3)
                    {
                        mainMessage += (char)111;
                    }
                }
                else if (mainDigit == 7)
                {
                    if (digit.Length == 1)
                    {
                        mainMessage += (char)112;
                    }
                    else if (digit.Length == 2)
                    {
                        mainMessage += (char)113;
                    }
                    else if (digit.Length == 3)
                    {
                        mainMessage += (char)114;
                    }
                    else if (digit.Length == 4)
                    {
                        mainMessage += (char)115;
                    }
                }
                else if (mainDigit == 8)
                {
                    if (digit.Length == 1)
                    {
                        mainMessage += (char)116;
                    }
                    else if (digit.Length == 2)
                    {
                        mainMessage += (char)117;
                    }
                    else if (digit.Length == 3)
                    {
                        mainMessage += (char)118;
                    }
                }
                else if (mainDigit == 9)
                {
                    if (digit.Length == 1)
                    {
                        mainMessage += (char)119;
                    }
                    else if (digit.Length == 2)
                    {
                        mainMessage += (char)120;
                    }
                    else if (digit.Length == 3)
                    {
                        mainMessage += (char)121;
                    }
                    else if (digit.Length == 4)
                    {
                        mainMessage += (char)122;
                    }
                }
                else if (mainDigit == 0)
                {
                    mainMessage += " ";
                }

            }

            Console.WriteLine(mainMessage);
        }
    }
}
