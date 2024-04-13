using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        public static void Main_Task3()
        {
            string inputFile = "C:\\Users\\Anatoha\\github-classroom\\VLazorykOOP\\csharplab8-Mykytiuk-Anatolii-1\\Lab8CSharp\\inputTask3.txt";
            string outputFile = "C:\\Users\\Anatoha\\github-classroom\\VLazorykOOP\\csharplab8-Mykytiuk-Anatolii-1\\Lab8CSharp\\outputTask3.txt";

            string inputText = File.ReadAllText(inputFile);

            
            MatchCollection matches = Regex.Matches(inputText, @"\b\w+\b");

            
            var seenWords = new HashSet<string>();
            var resultWords = new List<string>();

            foreach (Match match in matches)
            {
                string word = match.Value;

                
                if (!seenWords.Contains(word))
                {
                    resultWords.Add(word);
                    seenWords.Add(word);
                }
            }

            
            string result = string.Join(" ", resultWords);

            File.WriteAllText(outputFile, result);

            Console.WriteLine("The result is successfully written to the output file");
        }
    }
}
