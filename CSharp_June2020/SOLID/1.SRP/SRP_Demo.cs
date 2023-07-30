using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static System.Console;

namespace CSharp_June2020.SOLID.SRP
{
   
    public class Journal 
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;
        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }
        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine,entries);
        }
    }
    public class Persistence
    {
        public void SaveToFile(Journal j, string fileName, bool overwrtie = false)
        {
            if (overwrtie || !File.Exists(fileName))
                File.WriteAllText(fileName, j.ToString());
        }
    }
    class SRP_Demo
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            WriteLine(j.ToString());


            var fileName = @"c:\Temp\test9.txt";
            var presistence = new Persistence();
            presistence.SaveToFile(j, fileName, true);
            Process.Start(fileName);
        }
    }

}
