using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task3
{
    public static class WordsListWorker
    {
        public static List<Words> GetWordsWithNumber(HashSet<string> words, string text)
        {
            List<Words> result = new List<Words>();
            string textLower = text.ToLower();
            
            foreach (var word in words)
            {
                string pattern = @"\b" + word + @"\b";

                int number = new Regex(pattern).Matches(textLower).Count;
                if (number > 0)
                {
                    result.Add(new Words(word, number));
                }
            }
            return result;
        }

        public static string GetListToString(List<Words> words)
        {
            StringBuilder result = new StringBuilder();
            result.Append("________________________\n").Append(string.Format("| {0,-13}| {1,-7}|\n", "keyword", "number"));

            foreach (Words word in words)
            {
                result.Append(word);
            }
            result.Append("________________________\n");
            return result.ToString();
        }

        public static HashSet<string> GetWordsWithoutRepeat(string[] wordsArray)
        {
            HashSet<string> wordsWithoutRepeat = new HashSet<string>();
            foreach (var word in wordsArray)
            {
                wordsWithoutRepeat.Add(word.ToLower());
            }
            return wordsWithoutRepeat;
        }
    }
}
