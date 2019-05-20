using System;

namespace Fundamentals.Services
{
    public static class ReverseStringService
    {
        public static string Reverse(string input)
        {
            if(String.IsNullOrEmpty(input))
            {
                return input;
            }

            var result = string.Empty;

            for (int i = input.Length - 1; i >= 0 ; i--)
            {
                result += input[i];
            }

            return result;
        }
    }
}
