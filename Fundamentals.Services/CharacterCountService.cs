using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Services
{
    public static class CountCharactersService
    {
        public static string CountCharacters(string input)
        {
            return string.Empty;
            
            // while(input.Contains(' '))
            // {
            //     input.Remove(input.IndexOf(' '));
            // }

            // IDictionary<char, int> countDict = new Dictionary<char, int>();
            // for(int i = 0; i < input.Length; i++)
            // {
            //     var value = 0;
            //     if(!countDict.TryGetValue(input[i], out value))
            //     {
            //         countDict.Add(input[i], 1);
            //     }
            //     else
            //     {
            //         var currentCount = 0;
            //         countDict.TryGetValue(input[i], out currentCount);

            //         countDict[input[i]] = currentCount + 1;
            //     }
            // }

            // var result = new StringBuilder();
            // foreach(var element in countDict)
            // {
            //     result.Append($"{element.Key} - {element.Value}\n");
            // }
            // return result.ToString();
        }
    }

}