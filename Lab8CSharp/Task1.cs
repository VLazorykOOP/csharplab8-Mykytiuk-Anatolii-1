using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        public static void Main_Task1()
        {
            string inputFile = "C:\\Users\\Anatoha\\github-classroom\\VLazorykOOP\\csharplab8-Mykytiuk-Anatolii-1\\Lab8CSharp\\inputTask1.txt";
            string outputFile = "C:\\Users\\Anatoha\\github-classroom\\VLazorykOOP\\csharplab8-Mykytiuk-Anatolii-1\\Lab8CSharp\\outputTask1.txt";

            string[] lines = File.ReadAllLines(inputFile);

            int count = 0;

            foreach (string line in lines)
            {
                MatchCollection matches = Regex.Matches(line, @"\b(?:https?://)?(?:www\.)?[\w.-]+\.(?:cv\.ua)\b");

                foreach (Match match in matches)
                {
                    File.AppendAllText(outputFile, match.Value + Environment.NewLine);
                    count++;
                }
            }

            Console.WriteLine($"Found and recorded {count} cv.ua links.");
        }
    }
}
