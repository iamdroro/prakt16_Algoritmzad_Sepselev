using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prac16zad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();      
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                
                if (long.Parse(textBox1.Text) > 0)
                {
                    Dictionary<string, long> podschet = new Dictionary<string, long>();
                    using (StreamReader rx = new StreamReader("r1.txt"))
                    {
                        string chtenie;
                        while ((chtenie = rx.ReadLine()) != null)
                        {                           
                            string[] strana = chtenie.Split(' ');
                            string country = strana[0];
                            if (strana.Length == 4)
                            {
                                long numeric = long.Parse($"{strana[1]}{strana[2]}{strana[3]}");
                                podschet[country] = numeric;
                            }
                            else if (strana.Length == 5)
                            {
                                long numeric = long.Parse($"{strana[1]}{strana[2]}{strana[3]}{strana[4]}");
                                podschet[country] = numeric;
                            }
                        }
                    }
                    var sort = podschet.Where(a => a.Value > long.Parse(textBox1.Text)).OrderBy(a => a.Key.Length).ThenBy(a => a.Key);
                    foreach (var yt in sort)
                    {
                        listBox1.Items.Add($"{yt.Key} {yt.Value}");
                    }
                }
                else MessageBox.Show("Вы ввели отрицательное число", "Сообщение", MessageBoxButtons.OK);
            }
            catch { MessageBox.Show("Введите число правельно!", "Сообщение", MessageBoxButtons.OK); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

