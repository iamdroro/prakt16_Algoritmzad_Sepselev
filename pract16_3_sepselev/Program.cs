using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract16_3_sepselev
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Сколько элементов вводится в массив? ");
                int a = int.Parse(Console.ReadLine());
                double[] gt = new double[a];
                for (int i = 0; i < gt.Length; i++)
                {
                    Console.WriteLine($"Введите {i + 1} элемент ");
                    gt[i] = double.Parse(Console.ReadLine());
                }
                var n = gt.GroupBy(x => x).ToDictionary(b => b.Key, b => b.Count());
                Console.WriteLine("Частота элементов в массиве ");
                foreach (var juj in n)
                {
                    Console.WriteLine("{0}-{1}", juj.Key, juj.Value);
                }
                Console.WriteLine("число * на его частоту ");
                foreach (var juj in n)
                {
                    Console.WriteLine("{0}-{1}", juj.Key * juj.Value, juj.Value);
                }
            }
            catch { Console.WriteLine("You have a little misstake in your writing"); }
            Console.ReadLine();
        }
       
    }
}
