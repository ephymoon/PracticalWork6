using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа нахождения максимального модуля числа из массива.\nВведите количество элементов массива:");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[k];
            Random rnd = new Random();
            Console.Write("Эллементы массива:\n");
            for (int i = 0; i < k; i++)
            {
                x[i] = rnd.Next(-50,50);
                Console.Write(x[i] + " ");

            }
            Console.WriteLine();
            int max = 0;
            for (int i = 0; i < k; i++)
            {
                if (Math.Abs(x[i]) > max) max = Math.Abs(x[i]);
            }
            Console.Write("Максимальное число в массиве по модулю: " + max);
            Console.Write("\nДля завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
