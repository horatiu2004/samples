using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class UpperCase
    {
        public static string CamelCase(this string str)
        {

            string[] words = str.Split(' ');
            words = words.Select(element => {
                string word;
                word = element.Substring(0, 1).ToUpper();
                word = word + element.Substring(1);
                return word;
            }).ToArray();


            return String.Join("", words);
        }



      public static IEnumerable<int> EvenNumbers(this IEnumerable<int> numbers)
        {
            return numbers.Where(element => element % 2 == 0);
        }
    }
}
