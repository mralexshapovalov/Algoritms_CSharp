using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
     class Program
     {
         static void Binary_Search(int[] array, int key)
         {
            
            int middle_array = 0;
            int left = 0;
            int right = array.Length - 1;
            do
            {
                middle_array = (left + right) / 2;
                if (key > array[middle_array])
                    left = middle_array + 1;
                else
                    right = middle_array - 1;
            } while (array[middle_array] != key && (left <= right));


            if (array[middle_array] == key)
            {
                Console.WriteLine($"Данный элемент находится в ячейке {middle_array}");
            }
            else
            {
                Console.WriteLine("Данный элемент в массиве не найдет");
            }

         }

        static void Main(string[] args)
        {
            int value = 0;

            int[] array = new int[] { 1, 3, 5, 7, 9, 11, 12, 13 };

            Console.WriteLine("Вывод массива");

            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + ",");
            }

            Console.WriteLine("\nВведите значение ,которое необходимо найти");
                
            value = Convert.ToInt32(Console.ReadLine());
           
            Binary_Search(array, value);


        }
     }
}
