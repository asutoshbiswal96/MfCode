using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace logErrorAndWarnings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("ErrorLog.txt");
            string fileName = "logErrorAndWarnings.txt";
            string[] splittedLine=new string[] { };
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (var sw = new StreamWriter(fileName))
            {
                foreach (string line in lines)
                {
                    try {
                        splittedLine = line.Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);
                        sw.WriteLine("{0} {1}",splittedLine[0], splittedLine[2]);
                    }
                    catch(Exception exp)
                    {

                    }
                    }
            }
           

        }
    }
}