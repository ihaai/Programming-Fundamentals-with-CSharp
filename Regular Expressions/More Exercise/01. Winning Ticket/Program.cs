using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Winning_Ticket
{
    public class WinTicket
    {
        Regex pattern = new Regex(@"(\${6,10}|\@{6,10}|\#{6,10}|\^{6,10})");
        private string left;
        private string right;
        public Match match;

        public bool ValidateTicket(string ticket)
        {
            if (ticket.Length != 20)
                return false;
            return true;
        }

        public bool RegexValidation(string ticket)
        {
            if (pattern.IsMatch(ticket))
            {
                match = pattern.Match(ticket);
                return true;
            }
            return false;
        }

        public string GetLeftSymbols(string ticket)
        {
            left = pattern.Match(string.Join("", ticket.Take(10))).Value;
            return left;
        }

        public string GetRightSymbols(string ticket)
        {
            right = pattern.Match(string.Join("", ticket.Skip(10).Take(10))).Value;
            return right;
        }

        public Match GetMatch(string ticket) => pattern.Match(ticket);

        public int LeftSymbolCount(string ticket) => left.Count(x => x == match.Value[0]);

        public int RightSymbolCount(string ticket) => right.Count(x => x == match.Value[0]);

        public string NoMatch(string ticket) => $"ticket \"{ticket}\" - no match";

        public string Invalid(string ticket) => "invalid ticket";

        public string Jackpot(string ticket, int min, int symbol) => $"ticket \"{ticket}\" - {min}{Char.ConvertFromUtf32(symbol)} Jackpot!";

        public string NormalWin(string ticket, int min, int symbol) => $"ticket \"{ticket}\" - {min}{Char.ConvertFromUtf32(symbol)}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            WinTicket ticket = new WinTicket();
            StringBuilder sb = new StringBuilder();
            List<string> input = Console.ReadLine().Trim().Split(new[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (ticket.ValidateTicket(input[i]))
                {
                    if (ticket.RegexValidation(input[i]))
                    {
                        Match match = ticket.match;
                        string left = ticket.GetLeftSymbols(input[i]);
                        string right = ticket.GetRightSymbols(input[i]);
                        int leftCount = ticket.LeftSymbolCount(input[i]);
                        int rightCount = ticket.RightSymbolCount(input[i]);
                        int min = Math.Min(leftCount, rightCount);

                        if (min == 10)
                        {
                            Console.WriteLine(ticket.Jackpot(input[i], min, match.Value[0]));
                        }
                        else if (leftCount == 0 || rightCount == 0)
                        {
                            Console.WriteLine(ticket.NoMatch(input[i]));
                        }
                        else
                        {
                            Console.WriteLine(ticket.NormalWin(input[i], min, match.Value[0]));
                        }
                    }
                    else
                    {
                        Console.WriteLine(ticket.NoMatch(input[i]));
                    }
                }
                else
                {
                    Console.WriteLine(ticket.Invalid(input[i]));
                }
            }
        }
    }
}