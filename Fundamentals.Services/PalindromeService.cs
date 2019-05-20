using System;

namespace Fundamentals.Services
{
    public static class PalindromeService
    {
        public static string IsPalindrome(string input)
        {
            var testInput = new char[input.Length];

            for(int i = 0; i < input.Length / 2; i++)
            {
                if(input[i].Equals(input[input.Length - 1 - i]))
                {
                    testInput[i] = input[i];
                    testInput[input.Length - 1 - i] = input[input.Length - 1 - i];
                }
                else
                {
                    return "Not Palindrome";
                }
            }

            return "Palindrome";
        }
    }
}