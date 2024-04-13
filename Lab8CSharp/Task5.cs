using System;
using System.IO;

namespace Task5
{
    class Program
    {
        public static void Main_Task5()
        {
            string studentSurname = "Микитюк";

           
            string tempFolderPath = @"C:\temp\";

          
            string studentFolder1 = studentSurname + "1";
            string studentFolder2 = studentSurname + "2";
            Directory.CreateDirectory(Path.Combine(tempFolderPath, studentFolder1));
            Directory.CreateDirectory(Path.Combine(tempFolderPath, studentFolder2));

           
            string t1FilePath = Path.Combine(tempFolderPath, studentFolder1, "t1.txt");
            string t2FilePath = Path.Combine(tempFolderPath, studentFolder1, "t2.txt");
            string t3FilePath = Path.Combine(tempFolderPath, studentFolder2, "t3.txt");

            
            File.WriteAllText(t1FilePath, "<Шевченко Степан Іванович, 2001> року народження, місце проживання <м. Суми>");

            
            File.WriteAllText(t2FilePath, "<Комар Сергій Федорович, 2000> року народження, місце проживання <м. Київ>");

           
            string t1Content = File.ReadAllText(t1FilePath);
            string t2Content = File.ReadAllText(t2FilePath);

            
            File.WriteAllText(t3FilePath, t1Content + Environment.NewLine + t2Content);

            
            string destinationFolder2 = Path.Combine(tempFolderPath, studentFolder2);
            File.Move(t2FilePath, Path.Combine(destinationFolder2, "t2.txt"));

            
            File.Copy(t1FilePath, Path.Combine(destinationFolder2, "t1.txt"), true);

            
            Directory.Move(Path.Combine(tempFolderPath, studentFolder1), Path.Combine(tempFolderPath, "ALL"));

            
            string[] allFiles = Directory.GetFiles(Path.Combine(tempFolderPath, "ALL"));
            foreach (string file in allFiles)
            {
                Console.WriteLine($"File Name: {Path.GetFileName(file)}");
                Console.WriteLine($"Size: {new FileInfo(file).Length} bytes");
                Console.WriteLine($"Path: {file}");
                Console.WriteLine();
            }
        }
    }
}