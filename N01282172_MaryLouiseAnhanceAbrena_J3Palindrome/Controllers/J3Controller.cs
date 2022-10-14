using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace N01282172_MaryLouiseAnhanceAbrena_J3Palindrome.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Counting how many characters are there in a hidden palindrome in a string
        /// </summary>
        /// <param name="palindrome">The input string</param>
        /// <param name="count">How many palindrome are there in a string</param>
        /// <returns>Output the total number of letters of the longest palindrome contained in the input word.</returns>
        /// <example>
        /// Get api/j3/hiddenpalindrome/banana --> 5
        /// Get api/j3/hiddenpalindrome/mom --> 3
        /// </example>
        /// <logic>
        /// The first thing that it needs to do is to check each combination of the string provided 
        /// (using for loop. Starting with the palindrome.length ends when the string is less than 0)
        /// Once every combination is checked, it needs to confirm if the string have palindrome
        /// By doing the same thing, checking from the length of the palindrome all the way to zero
        /// Once we find if there is a palindrome in the string, it'll stop
        /// If the string doesn't have any palindrome, it'll stop right away and output 0 
        /// If there's a palindrome, using if statement, it'll check the longest palindrome of the string
        /// Then it should start counting the characters of the of longest palindrome in the string
        /// Then the output of the number of charactes of the palindrome will be output.
        /// </logic>

        [HttpGet]
        [Route("api/j3/hiddenpalindrome/{palindrome}")]

        public int Get(string palindrome)
        {
            string palindromeReverse = "";
            int counts = 0;


            for (int i = palindrome.Length; i < 0; i++)
            {
                int combinations = palindrome.Length - i + 1;

                for (int k = 0; k < combinations; k++)
                {
                    palindrome.Substring(k, k + 1);
                    palindromeReverse += palindrome[i];

                    if (palindrome[i] == palindrome[combinations])
                    {
                        int characCounts = palindrome.Count();
                        counts++;
                    }
                }
            }
            return counts;
        }
    }
} 

