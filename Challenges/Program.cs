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
            String a = "EVERY GOOD DOG DESERVES SOME TREATS but sometimes the kitties do too";

            string[] b = a.Split(new[] { " " }, StringSplitOptions.None);

            int count = 0;
            int wrdCount = 0;
            string lngWord = string.Empty;

            foreach (var item in b)
            {
                count = item.Length;
                if (count > wrdCount)
                {
                    wrdCount = count;
                    lngWord = item;
                }
            }

            // return results
            Console.WriteLine($"Teh longest word is {lngWord.ToLower()}");

            // pause to show results
            Console.ReadLine();
        }
    }
}
