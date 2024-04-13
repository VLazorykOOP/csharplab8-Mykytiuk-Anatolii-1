using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        public static void Main_Task2()
        {
            string inputFile = "C:\\Users\\Anatoha\\github-classroom\\VLazorykOOP\\csharplab8-Mykytiuk-Anatolii-1\\Lab8CSharp\\inputTask2.txt";
            string outputFile = "C:\\Users\\Anatoha\\github-classroom\\VLazorykOOP\\csharplab8-Mykytiuk-Anatolii-1\\Lab8CSharp\\outputTask2.txt";

            string inputText = File.ReadAllText(inputFile);

           
            string englishPattern = @"\b[A-Za-z]+\b";
            
            string ukrainianPattern = @"\b[АаОоЕеУуИиІіЄєЯяЮюЇї]\w*\b";

            
            string result = Regex.Replace(inputText, englishPattern, "...");

            
            result = Regex.Replace(result, ukrainianPattern, "");

            File.WriteAllText(outputFile, result);

            Console.WriteLine("English words replaced with three dots and Ukrainian words starting with a vowel letter have been removed successfully");
        }
    }
}
