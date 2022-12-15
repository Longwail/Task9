using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_1Console
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку : ");
            string line = Console.ReadLine();
            Console.WriteLine("Заданная строка = " + line);
            Console.Write("Введите букву : ");
            char b = char.Parse(Console.ReadLine());

            FileStream f = new FileStream("ch3.dat", FileMode.Create);
            using (BinaryWriter mem = new BinaryWriter(f))
            {
                mem.Write(line);
                
            } ;

            using (BinaryReader reader = new BinaryReader(File.Open("ch3.dat", FileMode.Open)))
            {
                string line1 = reader.ReadString();
                line = line1;
            };
            using (StreamWriter meme = new StreamWriter(File.Open("ch3.txt", FileMode.Create)))
            {
                meme.Write(line);
            };
            Console.WriteLine("Заданные слова: ");
            string[] line_ar = line.Split(' ');
            int count = 0;
            foreach (var item in line_ar)
            {
                try
                {
                    if (item[0] == b)
                    {
                        Console.WriteLine(item);
                        count++;
                    }
                }
                catch
                {
                    continue;
                }
            }
            if (count == 0) Console.Write("Нет слов на заданную букву");
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
