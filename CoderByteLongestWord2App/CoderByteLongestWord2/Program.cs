using System.Text.RegularExpressions;

namespace CoderByteLongestWord2
{
    public class Program
    {
        static string LongestWord(string sen)
        {
            string wordss = sen.ToLower();
            var words = Regex.Replace(sen.ToLower(), "[^a-zA-Z0-9 ]", "")
                .Split(" ");

            string longest = words[0];

            foreach (string word in words)
                if (word.Length > longest.Length) longest = word;

            return longest;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LongestWord("I love Coffe and? milk.. lalalalala"));
        }
    }
}