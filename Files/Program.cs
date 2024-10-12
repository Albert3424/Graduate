#define WRITE_TO_FILE
#define READ_FROM_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("File.txt");
            sw.WriteLine("Hello Files");
            sw.Close();
            sw = File.AppendText("File.txt");
            sw.WriteLine("Append to file");
            sw.Close();
            Process.Start("notepad", "file.txt");


            StreamReader sr = new StreamReader("File.txt");
            while(!sr.EndOfStream)
            {
                string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
            }
            sr.Close();
        }
    }
}
