using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // body
            string line = "Display the pattern like pyramid using the alphabet.";
            string result = string.Empty;
            List<string> wordsList = new List<string>();
            string[] words = line.Split(new[] {" "}, StringSplitOptions.None);

            for (int i = words.Length - 1; i <= 0; i--)
            {
                result = result + words[i] + "";
            }
            wordsList.Add(result);
            foreach (var s in wordsList)
            {
                Console.WriteLine("\nReverse String " + s);
            }

            // return results



            // pause to show results
            Console.ReadLine();
        }
    }
}
