// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;

            double [] array = {2.3, 12.08, 21.05, 1.11, 6.41, 31.81, 25.03, 58.12, 41.53, 16.99};

            double maxNum = array[0];
            double minNum = array[0];
         
            for (int i = 0; i < size; i++)
            {
            
                if (maxNum < array[i])
                {
                    maxNum = array[i];
                }

                else if (minNum > array[i])
                {
                    minNum = array[i];
                }
            }
            System.Console.WriteLine(maxNum - minNum);
             
        }    
    }
}
