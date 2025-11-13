using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match
{
    class Program
    {
        static void Main()
        {
            string text = "Salam Kamran. Necəsən Kamran ";
            Console.WriteLine(text.MatchCount("Kamran"));
            int n1 = 535;
            int n2 = 467;

            Console.WriteLine(n1.IsPalindrome()); 
            Console.WriteLine(n2.IsPalindrome()); 
        }

    }
}