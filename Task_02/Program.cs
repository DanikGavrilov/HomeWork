// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

using System;

namespace Task_02
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
                if (array [j] %2 == 0)
                {
                    count = count + 1;
                }
            }
            System.Console.WriteLine(count);
        }
    }
}
