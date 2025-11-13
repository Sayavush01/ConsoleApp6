using ConsoleApp6;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = 5;
        Console.WriteLine(n.IsOdd());
        Console.WriteLine(n.IsEven());
        string str = "Hello123";
        Console.WriteLine(str.IsContainsDigit());
        string str2 = "hello";
        Console.WriteLine(str2.ToCapitalize());
        int[] arr = { 1, 2, 3, 2, 4, 2 };
        int value = 2;
        int[] indexes = arr.GetValueIndexes(value);
        Console.WriteLine(string.Join(", ", indexes));
        string str3 = "Hi. My name is John";
        Console.WriteLine(str3.GetFirstSentence());
        string str4 = "hello whats up";
        Console.WriteLine(str4.GetSecondWord());


    }

}