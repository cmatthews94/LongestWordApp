using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LongestWordApp
{
    public class ApplicationLogic
    {

        private readonly static List<string> allWords = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(@"C:\Github\LongestWordApp\LongestWordApp\Dictionary_Array.json"));
        public static List<string> GetFilteredAndSortedList(string bannedChars, int quantityOfResults)
        {
            var finalList = new List<string>();
                foreach (var word in allWords)
                {
                    if(ValidationLogic.MatchIfCurrentWordMatchesDynamicRegex(bannedChars, word))
                    {
                        finalList.Add(word);
                    }
                }
                return finalList.OrderByDescending(x => x.Length).Take(quantityOfResults).ToList();
        }
        public static string GetNumberOfFilteredWords(string bannedChars)
        {
            int count = 0;
                foreach (var word in allWords)
                {
                    if(ValidationLogic.MatchIfCurrentWordMatchesDynamicRegex(bannedChars, word))
                    {
                        count++;
                    }
                }
            return count.ToString();
        }
    }
}

