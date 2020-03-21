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
                Console.WriteLine("Type the amount of results you'd like to display...");
                var resultsQuantity = Console.ReadLine();

                //checks that the strings provided by the user are not empty and starts the loop again if bad characters
                if(String.IsNullOrEmpty(bannedLetters) || !ValidationLogic.DoesStringContainOnlyLetters(bannedLetters))
                {
                    Console.WriteLine("Bad input values, please enter letters only");
                    count++;
                }
                else
                {
                    if(String.IsNullOrEmpty(resultsQuantity) || !ValidationLogic.DoesStringContainOnlyNumbers(resultsQuantity))
                    {
                        Console.WriteLine("Bad input values, please enter numbers only");
                        count++;
                    }
                    else
                    {
                        var finalList = ApplicationLogic.GetFilteredAndSortedList(bannedLetters, int.Parse(resultsQuantity));
                        for(int i = 0; i < int.Parse(resultsQuantity); i++)
                        {
                            Console.WriteLine(finalList[i]);
                        }
                    }

                }
            }
        }
    }
}
