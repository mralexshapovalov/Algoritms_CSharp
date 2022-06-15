using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_sort
{
    internal class Program //Быстрая сортировка
    {


        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            int i = left, j = right;

            int picot = array[(left + right) >> 1]; //Опорный элемент


            while (i <= j)
            {
                while (array[i] < picot)
                {
                    i++;
                }
                while (array[j] > picot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;

                    i++;
                    j--;

                }

            }

            if (left < j)
            {
                QuickSort(array, left, j);
            }

            if (i < right)
            {
                QuickSort(array, i, right);
            }
        }
        static void Main(string[] args)
        {



            int[] mas = { 5, 1, 8, 5, 2, 6, 1, 2, 6, 9 };




            QuickSort(mas);



            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"{mas[i]}\n");
            }
        }
    }
}
