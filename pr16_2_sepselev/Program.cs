using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace pr16_2_sepselev
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("Заполните массив с использованием / ");
            string[] lt = Console.ReadLine().Split('/');
            foreach (string st in lt)
            {
                foreach (char n in st)
                {
                    if (char.IsDigit(n))
                    {
                        c++;
                    }
                }
            }
            Console.WriteLine($"Цифр в массиве: {c}") ;
            Console.WriteLine($"Элементов массива до символа / ");
            foreach (string st in lt)
            {
                if (st == "/")
                {
                    break;
                }
                if (st != "")
                {
                    Console.WriteLine(st);
                }
            }
            Console.WriteLine($"Элементы массива после / в верхних и нижнем регистре");
            foreach (string st in lt)
            {
                string i = "";
                if (st == "/")
                {
                    continue;
                }
                if (st == "")
                {
                    break;
                }
                foreach (char s in st)
                {
                    if (Char.IsUpper(s))
                    {
                        i += Char.ToLower(s);
                    }
                    else if (Char.IsLower(s))
                    {
                        i += Char.ToUpper(s);
                    }
                    else
                    {
                        i += s;
                    }
                }
                Console.WriteLine(i);
                StreamWriter kl = new StreamWriter("r1.txt", true);
                kl.WriteLine(i);
                kl.Close();
            }
            Console.WriteLine("Массив после изменения записался в файл");
            Console.ReadLine();
        }
    }
}
