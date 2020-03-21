using System;

namespace LongestWordApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while(count < count + 1)
            {
                //gets all the necessary user input values
                Console.WriteLine("Type the letters you want to ban (max 10) and press Enter or type \"exit\" to quit...");
                var bannedLetters = Console.ReadLine();
                Console.WriteLine("Type the amount of results (max 50) you'd like to display...");
                var resultsQuantity = Console.ReadLine();

                //checks that the strings provided by the user are not empty and starts the loop again if bad characters
                if(!ValidationLogic.IsUserInputValidBannedCharacters(bannedLetters))
                {
                    Console.WriteLine("Bad input values, please enter letters only with a maximum of 10 letters.");
                    count++;
                }
                else
                {
                    if(!ValidationLogic.IsUserInputValidResultsQuantity(resultsQuantity))
                    {
                        Console.WriteLine("Bad input values, please enter numbers only with a maximum of 50.");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("the " + $"{resultsQuantity}" + " longest words you can spell without " + $"\"{bannedLetters}\"" + " are:");
                        var finalList = ApplicationLogic.GetFilteredAndSortedList(bannedLetters, int.Parse(resultsQuantity));
                        for(int i = 0; i < int.Parse(resultsQuantity); i++)
                        {
                            Console.WriteLine(finalList[i] + " => " + $"{finalList[i].Length.ToString()}");
                        }
                    }

                }
            }
        }
    }
}
