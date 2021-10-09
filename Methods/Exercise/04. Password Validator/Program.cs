using System;

namespace _04._Password_Validator
{
    class Program
    {
        static bool firstRuleCheck = true;
        static bool secondRuleCheck = true;
        static bool thirdRuleCheck = true;

        static void CharactersRule(string pass)
        {
            if (pass.Length < 6)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                firstRuleCheck = false;
            }
            else
            {
                firstRuleCheck = true;
            }
        }

        static void CharactersAndDigitsOnlyRule(string pass)
        {
            string[] forbiddenCharacters = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", ",", "." };
            foreach (var element in forbiddenCharacters)
            {
                if (pass.Contains(element))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    secondRuleCheck = false;
                    return;
                }
            }
        }

        static void MustContainDigitsRule(string pass)
        {
            int count = new int();
            string[] digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            foreach (var element in digits)
            {
                if (pass.Contains(element))
                    count++;
            }
            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                thirdRuleCheck = false;
            }
            else
            {
                thirdRuleCheck = true;
            }
        }

        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            CharactersRule(password);
            CharactersAndDigitsOnlyRule(password);
            MustContainDigitsRule(password);

            if (firstRuleCheck && secondRuleCheck && thirdRuleCheck)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
