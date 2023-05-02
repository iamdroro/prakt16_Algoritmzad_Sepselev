using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt16Algoritm
{
    public partial class Form1 : Form
    {

        string Readtxt;
        int A = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                Readtxt = File.ReadAllText(file);
                button1.Visible = false;
                panel1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("Файл не был выбран!");
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string LT="";
            A = 0;
            for (int i = 0; i < Readtxt.Length; i++)
            {
                if (!char.IsPunctuation(Readtxt[i]))
                {
                    LT += Readtxt[i];
                }
            }
            string[] txt = LT.Split(' ');
            foreach (string txtone in txt)
            {
                string textbox = textBox1.Text.ToLower();
                if (txtone.ToLower() == textbox)
                {
                    A++;
                }
            }
            if (A>0)
            MessageBox.Show($"В тексте {Readtxt} было найдено {A} вхождений слова {textBox1.Text}", "Сообщение", MessageBoxButtons.OK);
            else MessageBox.Show($"Вхождений не было найдено", "Сообщение", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
