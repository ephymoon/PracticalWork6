using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа удвоения чисел массива.\nВведите количество элементов массива:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вводите элементы массива: ");
            int[] x = new int[k];
            for (int i = 0; i < k; i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < k; i++)
            {
                Console.Write(x[i] * 2 + " ");
            }
            Console.Write("\nДля завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
