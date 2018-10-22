using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder resultString = new StringBuilder();

            string text = "It is a very useful tool that OFFers yOU Very useful tool that offers documentation needed in all the documentation documentation needed in needed in one place whether it’s for Windows Phone development, Windows Store App Development, even";
            string pattern = @"\W+";
            string[] wordsArray = Regex.Split(text, pattern, RegexOptions.IgnorePatternWhitespace);

            resultString.Append($"Initial text:\r\n {text}");

            HashSet<string> wordsWithoutRepeat = WordsListWorker.GetWordsWithoutRepeat(wordsArray);

            List<Words> result = new List<Words>();
            
            result = WordsListWorker.GetWordsWithNumber(wordsWithoutRepeat, text);
            resultString.Append("Words:\n").Append(WordsListWorker.GetListToString(result));
            
            Console.WriteLine(resultString);
            Console.ReadLine();
        }
    }
}
