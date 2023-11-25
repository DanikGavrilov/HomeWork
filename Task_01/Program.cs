﻿// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = 10;
            int [] array = new int [size];
    
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(1,101);
            }
                
            // foreach (int item in array)
            // {
            //     System.Console.Write(item + " ");
            // }
            
            int count = 0;
    
            for (int j = 0; j < size; j++)
            {
                if (array [j] > 19 && array[j] < 91)
                {
                    count = count + 1;
                }
            }
            System.Console.WriteLine(count);

        }
    }
}
