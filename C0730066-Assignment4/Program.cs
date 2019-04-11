using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C0730066_Assignment4
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();
            string text = System.IO.File.ReadAllText("U:/Users/730066/C0730066-Assignment4/Beowulf.txt");
            p.FindNumberOfBlankSpaces(text);
            p.ProcessArrayList();

        }

        public void Run()
        {
            this.ReadTextFiles();
           
        }
            
        public void ReadTextFiles()
        {
            //Read file using StreamReader. Reads file line by line
            using (StreamReader file = new StreamReader("U:/Users/730066/C0730066-Assignment4/Beowulf.txt"))
            {
                int words = 1;
                int counter = 0;
                string ln;
               
                
               

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File contains {counter} lines.");
                Console.WriteLine("the number of words in the string: {0}", words);
            }
        }
        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;


            foreach (char c in line)

            {
                if (char.IsLetter(c))
                {
                    countletters++;
                }

                if (char.IsWhiteSpace(c))
                {
                    countSpaces++;
                }
            }

            Console.WriteLine("Number of words: " + countSpaces);

            return countSpaces;
        }
        public void ProcessArrayList()
        {
            int LineNumber = 0;
            foreach (var line in Beowulf)

            {

                if (ContainWord(line.ToString().ToLower(), "sea") && ContainWord(line.ToString().ToLower(), "fare"))
                {
                    Console.WriteLine(line);
                    Console.WriteLine("Line number is {0}", LineNumber);
                    LineNumber++;
                }
            }
            Console.WriteLine(LineNumber);
        }


        public bool ContainWord(string line, string Word)
        {
            if (line.Contains(Word) == true)
            {
                return true;
            }
            return false;
        }
    }
}




