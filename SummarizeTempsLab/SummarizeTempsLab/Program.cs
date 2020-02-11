using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string temps = "temps.txt";
            Console.WriteLine("What file do you want to access?");
            string file = Console.ReadLine();
            // temperature data is in temps.txt
            if (File.Exists(temps))
            {
                Console.WriteLine("Enter Temperature Threshold");
                string input = Console.ReadLine();
                int Threshold = int.Parse(input);

                int sumTemps = 0;
                int numAbove = 0;
                int numBelow = 0;
                int tempCount = 0;
                using (StreamReader sr = File.OpenText(temps))
                {
                    string line = sr.ReadLine();
                    int temp;
                    while (line != null)
                    {
                        temp = int.Parse(line);
                        sumTemps += temp;
                        tempCount++;
                        if (temp >= Threshold)
                        {
                            numAbove += 1;
                        }
                        else
                        {
                            numBelow += 1;
                        }
                   
                        line = sr.ReadLine();
                    }
                }
                Console.WriteLine("The Number above =" + numAbove);
                Console.WriteLine("The Number below =" + numBelow);
                int average = sumTemps / tempCount;
                Console.WriteLine("Average temp =" + average);

            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}
