using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Task9_1Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line = textBox1.Text;
            char b = textBox2.Text[0];

            FileStream f = new FileStream("ch3.dat", FileMode.Create);
            using (BinaryWriter mem = new BinaryWriter(f))
            {
                mem.Write(line);

            };

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
            int count = 0;
            string[] line_ar = line.Split(' ');
            foreach (var item in line_ar)
            {
                try
                {
                    if (item[0] == b)
                    {
                        textBox3.Text += item + ' ';
                        count++;
                    }
                }
                catch
                {
                    continue;
                }
            }
            if (count == 0)
            {
                textBox3.Text += "Нет слов на заданную букву";
            }
        }
    }
}
