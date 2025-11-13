using System.Runtime.CompilerServices;

namespace Match
{
    public static class MatchMethod
    {
        public static int MatchCount(this string str, string word)
        {
            int count = 0;
            int Index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == word[Index])
                    count++;

            }
            return count;


        }
        public static bool IsPalindrome(this int number)
        {
            int num = number;
            int dig = 0;

            while (number > 0)
            {
                int digit = number % 10;
                dig = dig * 10 + digit;
                number = number / 10;
            }

            return dig == num;
        }

    }
}
