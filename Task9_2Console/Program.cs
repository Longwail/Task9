using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                string[] lines = File.ReadAllLines("test.txt");
            using (StreamWriter g = new StreamWriter(File.Open("All.txt", FileMode.Create)))
            {
                foreach(string s in lines)
                {
                    g.WriteLine($"{s.TrimEnd()} - {s.Length}");
                }

            }
        }
    }
}