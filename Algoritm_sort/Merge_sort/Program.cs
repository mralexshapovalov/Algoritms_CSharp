using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_sort
{
    internal class Program
    {
        static public void MergeSort(int[] mas)
        {
            if (mas.Length <= 1)
            {
                return;
            }
            int leftSize = mas.Length / 2;

            int rightSize = mas.Length - leftSize;

            int[] left = new int[leftSize];
            int[] right = new int[rightSize];


            Array.Copy(mas, 0, left, 0, leftSize);
            Array.Copy(mas, leftSize, right, 0, rightSize);



            MergeSort(left);
            MergeSort(right);


            Megre(mas, left, right);



        }



        static void Megre(int[] mas, int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int targetIndex = 0;

            int remaing = left.Length + right.Length;


            while (remaing > 0)
            {
                if (leftIndex >= left.Length)
                {
                    mas[targetIndex] = right[rightIndex++];

                }
                else if (rightIndex >= right.Length)
                {
                    mas[targetIndex] = left[leftIndex++];
                }
                else if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    mas[targetIndex] = left[leftIndex++];

                }
                else
                {
                    mas[targetIndex] = right[rightIndex++];
                }
                targetIndex++;
                remaing--;

            }
        }

        static void Main(string[] args)
        {


            int[] mas = { 5, 1, 8, 5, 2, 6, 1, 2, 6, 9 };




            MergeSort(mas);



            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"{mas[i]}\n");
            }
        }
    }
}
