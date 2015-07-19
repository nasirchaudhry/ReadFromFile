using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Start namespace ReadFromFile
namespace ReadFromFile
{
    /// <summary>
    /// This program will read a list of names from text file and then it will split the names
    /// using split function
    /// </summary>

    //start class Program
    class Program
    {
        //start Main Method
        static void Main(string[] args)
        {
            // Read all the names from the text file. Each element of the array is one line of the file.           
            // Method # 1 to read text from file 
            string[] names = System.IO.File.ReadAllLines("TextToRead.txt");

            // Print all the names by using a foreach loop.            
            foreach (string line in names)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            // Method # 2 Creating a list peoplesName to store the names from text file
            List<Names> peoplesName = new List<Names>();
            
            // Using StreamReader to read text from file
            StreamReader readFile;
            readFile = File.OpenText("TextToRead.txt");

            while (!readFile.EndOfStream)
            {
                Names persons = new Names();
                persons.listNames = readFile.ReadLine();
                peoplesName.Add(persons);
            }

            // for loop to print out the names
            readFile.Close();
            for (int i = 0; i < peoplesName.Count; i++)
            {
                Console.WriteLine(peoplesName[i].listNames.ToString());
            }
            Console.WriteLine("");
            Console.ReadKey();

            // method to split the names
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            List<string> list  = new List<string>();
            using(StreamReader sr = new StreamReader("TextToRead.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(delimiterChars);
                    foreach (string word in words)
                    {
                        list.Add(word);
                        System.Console.WriteLine(word);
                    }
                }
            }                    
            Console.ReadKey();
        }// end main Method
    }// end class Program
}// end namespace ReadFromFile