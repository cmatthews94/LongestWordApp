using System;
using System.Text.RegularExpressions;

namespace LongestWordApp
{
    public static class ValidationLogic
    {
        //after sleeping and coming back to this issue, this seems to be the most effective way of dealing with the validation.
        public static bool DoesStringContainOnlyLetters(string userInput)
        {
            char[] input = userInput.ToCharArray();

            foreach(char c in input)
            {
                if (!Char.IsLetter(c))
                {
                    return false;
                }
                else return true;
            }
            return false;
        }
        public static bool DoesStringContainOnlyNumbers(string userInput)
        {
            char[] input = userInput.ToCharArray();

            foreach(char c in input)
            {
                if(!Char.IsDigit(c))
                {
                    return false;
                }
                else return true;
            }
            return false;
        }

        //Regex turned out to  not be the ideal solution to the issues I was having. Will continue to learn it as it does feel valuable.

        //Matches as true if all values in an input are numbers
        [Obselete]
        public static Regex MatchIfStringOnlyContainsNumbers = new Regex(@"\d+");
        //Matches as true if all values in an input are letters
        [Obselete]
        public static Regex MatchIfStringOnlyContainsLetters = new Regex(@"^\d");

        //creates a new Regex pattern to filter out words that include banned letters
        [Obselete]
        public static bool MatchIfCurrentWordMatchesDynamicRegex(string bannedChars, string word)
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
        //Matches as true if all values contain the banned letters
        [Obselete]
        public static Regex CreateNewDynamicRegexPattern(string bannedChars)
        {
            return new Regex(@"[" + bannedChars + @"]");
        }
    }
}
