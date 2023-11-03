using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("Inlet.in");

        int shortestWordLength = -1;

        foreach (string line in lines)
        {
            string[] words = line.Split(' ');

            foreach (string word in words)
            {
                if (shortestWordLength == -1 || word.Length < shortestWordLength)
                {
                    shortestWordLength = word.Length;
                }
            }
        }

        File.WriteAllText("Outlet.out", shortestWordLength.ToString());

        Console.WriteLine("Результат записан в файл Outlet.out.");
    }
}
