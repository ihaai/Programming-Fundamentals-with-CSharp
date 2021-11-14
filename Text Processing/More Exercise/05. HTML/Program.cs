using System;
using System.Text;

namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string header = Console.ReadLine(); 
            string content = Console.ReadLine();
            string comment = Console.ReadLine();

            sb.AppendLine($"<h1>\n      {header}\n</h1>");
            sb.AppendLine($"<article>\n     {content}\n</article>");

            while (comment != "end of comments")
            {
                sb.AppendLine($"<div>\n     {comment}\n</div>");
                comment = Console.ReadLine();
            }
            Console.WriteLine(sb);
        }
    }
}
