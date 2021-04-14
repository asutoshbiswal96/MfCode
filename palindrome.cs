

using System;
using System.Collections.Generic;
using System.Linq;

namespace file
{
    public class Palindrome
    {
        public static bool checkIsPalindrome(string word)
        {
            string revs = "";
            try
            {
                for (int i = word.Length - 1; i >= 0; i--) //String Reverse  
                {
                    revs += word[i].ToString();
                }
                return string.Equals(word, revs, StringComparison.OrdinalIgnoreCase);//String equal checking with ignorecase
            }
            catch (Exception exp)
            {
                return false;
            }

        }
        public static void Main()
        {
           
            string word = "aba";
            var isPalindrome = checkIsPalindrome(word);
            string outPut = string.Empty;
            if (isPalindrome)
            {
                outPut = "Palindrome";
            }
           else
            {
                outPut = "not Palindrome";
            }
            Console.WriteLine("{0} is {1}",word , outPut);
            Console.ReadLine();

        }
    }
}

