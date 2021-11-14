using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder decrypted = new StringBuilder();
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string crypted = Console.ReadLine();

            int keyIndex = 0;
            while (crypted != "find")
            {
                for (int i = 0; i < crypted.Length; i++)
                {
                    if (keyIndex >= key.Length)
                        keyIndex = 0;

                    int currentChar = crypted[i] - key[keyIndex];
                    decrypted.Append(Char.ConvertFromUtf32(currentChar));
                    keyIndex++;
                }

                int treasureIndexStart = decrypted.ToString().IndexOf("&") + 1;
                int treasureIndexEnd = decrypted.ToString().LastIndexOf("&");
                int cordsIndexStart = decrypted.ToString().IndexOf("<") + 1;
                int cordsIndexStop = decrypted.ToString().IndexOf(">");

                string treasure = decrypted.ToString()[treasureIndexStart..treasureIndexEnd];
                string cords = decrypted.ToString()[cordsIndexStart..cordsIndexStop];

                decrypted.Clear();
                decrypted.Append($"Found {treasure} at {cords}");
                Console.WriteLine(decrypted);
                decrypted.Clear();
                keyIndex = 0;

                crypted = Console.ReadLine();
            }
        }
    }
}
