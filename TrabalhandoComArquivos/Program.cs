using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Lucas Ortis\Downloads\file1.txt";
            string targetPath = @"C:\Users\Lucas Ortis\Downloads\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.Write("An error ocurred: " + e.Message);
            }
        }
    }
}
