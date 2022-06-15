using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    internal class Program
    {
        //Cортировка выбором

        static private void Swap(int[] mas, int left, int right)
        {

            if (left != right)
            {
                int temp = mas[left];
                mas[left] = mas[right];
                mas[right] = temp;
            }

        }



        static public void SelectionSort(int[] items)
        {
            {
                int sortedRangeEnd = 0;


                while (sortedRangeEnd < items.Length)
                {
                    int nextIndex = FindIndexofSmallesFromIndex(items, sortedRangeEnd);

                    Swap(items, sortedRangeEnd, nextIndex);
                    sortedRangeEnd++;
                }
            }


        }


        static private int FindIndexofSmallesFromIndex(int[] items, int sortedRangeEnd)
        {
            int currentSmallest = items[sortedRangeEnd];
            int currentSmallestIndex = sortedRangeEnd;

            for (int i = sortedRangeEnd + 1; i < items.Length; i++)
            {
                if (currentSmallest.CompareTo(items[i]) > 0)
                {
                    currentSmallest = items[i];
                    currentSmallestIndex = i;
                }
            }

            return currentSmallestIndex;
        }


        static void Main(string[] args)
        {
            int[] mas = { 8, 1, 6, 4, 1, 2, 3, 56, 77, 1 };



            SelectionSort(mas);


            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"{mas[i]}\t");
            }

        }
    }
}
