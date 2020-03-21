using System;
using System.Text.RegularExpressions;

namespace LongestWordApp
{
    public static class ValidationLogic
    {
        //after sleeping and coming back to this issue, this seems to be the most effective way of dealing with the validation.
        public static bool IsUserInputValidBannedCharacters(string userInput)
        {
            char[] userInputAsCharArray = userInput.ToCharArray();

            if(String.IsNullOrEmpty(userInput) || userInput.Length > 10)
            {
                return false;
            }
            foreach (char c in userInputAsCharArray)
            {
                if(!Char.IsLetter(c)|| Char.IsWhiteSpace(c))
                {
                    return false;
                }
                else return true;
            }
            return false;
        }
        public static bool IsUserInputValidResultsQuantity(string userInput)
        {
            char[] input = userInput.ToCharArray();

            if (String.IsNullOrEmpty(userInput) || int.Parse(userInput) > 50)
            {
                return false;
            }
            foreach (char c in input)
            {
                if(!Char.IsDigit(c) || Char.IsWhiteSpace(c))
                {
                    return false;
                }
                else return true;
            }
            return false;
        }
        public static bool MatchTrueIfCurrentWordMatchesDynamicPattern(string bannedChars, string word)
        {
            if(!CreateNewDynamicRegexPattern(bannedChars).IsMatch(word))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Regex CreateNewDynamicRegexPattern(string bannedChars)
        {
            return new Regex(@"[" + bannedChars + @"]");
        }
    }
}
