﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
int expo = a;
for(int i = 1; i < b; i++)
expo = expo*a;
Console.WriteLine("А в степени В равно: " + expo);