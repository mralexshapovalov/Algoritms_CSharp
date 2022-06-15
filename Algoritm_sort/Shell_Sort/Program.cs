using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell_Sort
{
    internal class Program//Сортировка Шелла
    {


        public static void Shell_sort(int[] mas)
        {
            int N = mas.Length;
            int step = mas.Length / 2;
            while (step >= 1)
            {
                int k = step;
                for (int i = k + 1; i < mas.Length; i++)
                {
                    int temp = mas[i];
                    int j = i - k;
                    while ((j > 0) && (temp < mas[j]))
                    {
                        mas[j + k] = mas[j];
                        j = j - k;
                    }
                    mas[j + k] = temp;
                }
                step = 3 * step / 5;
            }
        }


        static void Main(string[] args)
        {
            int[] mas = { 3, 2, 1, 6, 4, 8, 5, 9 };

            Console.WriteLine("Массив до сортировки");



            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]}\t");
            }
            Console.WriteLine("\nОтсортированный массив ");


            Shell_sort(mas);

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]}\t");
            }
        }
    }
}
