using System;
using System.ComponentModel.Design;

namespace ConsoleApp6
{
    public static class ExtensionsMethods
    {
        public static bool IsOdd(this int number) => number % 2 != 0;
        public static bool IsEven(this int number) => number % 2 == 0;

        public static bool IsContainsDigit(this string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        public static string ToCapitalize(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();

        }

        public static int[] GetValueIndexes(this int[] arr, int value)
        {

            int count = 0;
            foreach (int item in arr)
            {
                if (item == value)
                {
                    count++;
                }
            }
            int[] indexes = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    indexes[index] = i;
                    index++;
                }
            }

            return indexes;
        }
        public static string GetFirstSentence(this string str)
        {
            str = str.Trim();

            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                result += str[i];
                if (str[i] == '.')
                {
                    break;
                }
            }

            return result;
        }
        public static string GetSecondWord(this string str)
        {
            str = str.Trim();

            string word = "";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
                if (count == 1)
                {
                    word += str[i];
                }
                if (count > 1)
                {
                    break;
                }
            }
            return word;
        }


       





    }
}

