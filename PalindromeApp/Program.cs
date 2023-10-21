using System;

namespace PalindromeApp
{
    //Msimango 
    class Program
    {
        // A C# program to check if the word is a palindrome and returned a boolean 
        public static void Main(string[] args)
        {
            string[] words = { "racecar", "talented", "deified", "tent", "tenet" };
            Console.WriteLine("Is it a palindrome");
           
            foreach(string word in words)
            {
                Console.WriteLine($"Word :{word} ={IsPalindrome(word)}");
            }
           bool IsPalindrome(string w)
            {
                int start = 0;
                int end = w.Length - 1;
                while(start<end)
                {
                    if (w[start]!=w[end])
                    {
                        return false;
                    }
                    start++;
                    end--;
                }
                return true;
            }
        }
    }
}
