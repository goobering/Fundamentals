using System.Text;

namespace Fundamentals.Services
{
    public static class ReverseWordsService
    {
        public static string Reverse(string input)
        {
            var splitString = input.Split();
            var builder = new StringBuilder();
            for (int i = splitString.Length - 1; i >= 0 ; i--)
            {
                builder.Append(splitString[i]);
                if(i >= 1)
                {
                    builder.Append(" ");
                }
            }

            return builder.ToString();
        }
    }
}