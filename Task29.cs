﻿//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
int [] array = new int[8];
Console.Write("[");

for (int i = 0; i < array.Length; i++)
 {
    array [i] = new Random().Next(0, 100);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return array[a];
}