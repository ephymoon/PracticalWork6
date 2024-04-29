using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа переворачивания массива.\nВведите количество элементов массива:");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[k];
            int[] c = new int[k];
            Random rnd = new Random();
            Console.Write("Эллементы массива:\n");
            for (int i = 0; i < k; i++)
            {
                x[i] = rnd.Next(-50, 50);
                Console.Write(x[i] + " ");
            }
            c = x;
            Array.Reverse(c);
            Console.WriteLine();
            Console.WriteLine("Массив c: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.Write("\nДля завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
    