using System;
using System.Collections.Generic;
using System.IO;
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
            FileInfo fi = new FileInfo(@"C:\ABLogo.png");


            // return results
            Console.WriteLine($"The file {fi.FullName} is {fi.Length.ToString()} big.");


            // pause to show results
            Console.ReadLine();
        }
    }
}
