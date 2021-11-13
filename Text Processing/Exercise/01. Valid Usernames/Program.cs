using System;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        public static StringBuilder sb = new StringBuilder();
        static bool ValidUsername(string username)
        {
            if (username.Length < 3 || username.Length > 16)
                return false;

            for (int i = 0; i < username.Length; i++)
            {
                char currentChar = username[i];
                if (!char.IsLetterOrDigit(currentChar) && currentChar != '-' && currentChar != '_')
                    return false;
            }
            sb.Append(username);
            return true;
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            foreach (var username in input)
            {
                if (ValidUsername(username))
                {
                    Console.WriteLine(sb);
                    sb.Clear();
                }
            }
        }
    }
}
