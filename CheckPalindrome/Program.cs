using System;

namespace CheckPalindrome
{
    class Program
    {
        /// <summary>
        /// For inputString = "aabaa", the output should be checkPalindrome(inputString) = true; 
        /// For inputString = "abac", the output should be checkPalindrome(inputString) = false;
        /// For inputString = "a", the output should be checkPalindrome(inputString) = true.
        /// </summary>
        static void Main(string[] args)
        {
            bool CheckPalindrome(string inputString)
            {
                int j = inputString.Length - 1;
                for (int i = 0; i <= j; i++)
                {
                    if (inputString[i] != inputString[j])
                    {
                        return false;
                    }
                    j--;
                }
                return true;
            }

            Console.WriteLine(CheckPalindrome("aabaa"));
        }
    }
}
