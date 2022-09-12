using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLength];
            Random random = new Random();
            int randomNumberMin = 0;
            int randomNumberMax = 99;

            for (int arrayIndex=0; arrayIndex<array.Length; arrayIndex++)
            {
                array[arrayIndex] = random.Next(randomNumberMin, randomNumberMax+1);
            }

            Console.WriteLine("Неотсортированный массив:");
            Console.WriteLine();

            for (int arrayIndex = 0; arrayIndex < array.Length; arrayIndex++)
            {
                Console.Write(array[arrayIndex] + " ");
            }

            for (int arrayIndex = 0; arrayIndex < array.Length-1; arrayIndex++)
            {
                int minNumber = array[arrayIndex];
                int minIndex = arrayIndex;

                for (int arrayIndex2= arrayIndex+1; arrayIndex2 < array.Length; arrayIndex2++)
                {
                    if (array[arrayIndex2]< minNumber)
                    {
                        minNumber = array[arrayIndex2];
                        minIndex = arrayIndex2;
                    }
                }

                int tempForChange = array[arrayIndex];
                array[arrayIndex] = array[minIndex];
                array[minIndex] = tempForChange;
            }

            Console.WriteLine("Отсортированный массив:");
            Console.WriteLine();

            for (int arrayIndex = 0; arrayIndex < array.Length; arrayIndex++)
            {
                Console.Write(array[arrayIndex] + " ");
            }
        }
    }
}