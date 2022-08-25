//Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
using System;
class Program
{
    static void Main(string[] args)
    {
        int s = 4;
        int[] a = new int[s];

        int coll = 0; // кол-во четных чисел
        Random random = new Random();
        Console.Write("исходный массив: " );
        for (int i = 0; i < s; i++)
        {
            Console.Write($"{a[i] = random.Next(99, 999)}{"  "}");
            if (a[i] % 2 == 0 && a[i] > 0)
            coll += 1;
         }
       Console.Write($"{"количество четных чисел:  "}{coll}");
    }

}