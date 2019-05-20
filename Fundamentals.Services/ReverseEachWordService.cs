using System;
using System.Text;

namespace Fundamentals.Services
{
    public static class ReverseEachWordService
    {
        public static string Reverse(string input)
        {
            var splitInput = input.Split();
            var sentenceBuilder = new StringBuilder();

            for(int i = 0; i < splitInput.Length; i++)
            {
                var wordBuilder = new StringBuilder();
                for (int j = splitInput[i].Length - 1; j >= 0 ; j--)
                {
                    wordBuilder.Append(splitInput[i][j]);
                }

                sentenceBuilder.Append($"{wordBuilder.ToString()} ");
            }

            sentenceBuilder.Length--;
            return sentenceBuilder.ToString();
        }
    }
}