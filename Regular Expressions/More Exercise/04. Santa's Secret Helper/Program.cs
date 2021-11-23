using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    public class Helper
    {
        public List<string> goodNames = new List<string>();

        public string Name { get; set; }
        public string Type { get; set; }

        public Helper() { }

        public Helper(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public void CheckIfHelperIsGood(Helper helper)
        {
            if (helper.Type == "G")
                goodNames.Add(helper.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*\!(?<bType>[GN])\!");
            StringBuilder decrypted = new StringBuilder();
            Helper classInstance = new Helper();

            int key = int.Parse(Console.ReadLine());
            string crypted = string.Empty;

            while ((crypted = Console.ReadLine()) != "end")
            {
                foreach (var curChar in crypted)
                    decrypted.Append(Char.ConvertFromUtf32((char)curChar - key));

                string name = pattern.Match(decrypted.ToString()).Groups["name"].Value;
                string type = pattern.Match(decrypted.ToString()).Groups["bType"].Value;

                classInstance.CheckIfHelperIsGood(new Helper(name, type));

                decrypted.Clear();
            }
            Console.WriteLine(string.Join("\n", classInstance.goodNames));
        }
    }
}
