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

namespace Task9_2Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines("test.txt");
            using (StreamWriter g = new StreamWriter(File.Open("All.txt", FileMode.Create)))
            {
                foreach (string s in lines)
                {
                    g.WriteLine($"{s.TrimEnd()} - {s.Length}");
                }

            }
        }
    }
}
