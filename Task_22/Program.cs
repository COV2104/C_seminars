﻿// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= n)
{
    if (i < n)
        Console.Write(i * i + ",");
    else
        Console.Write(i * i);
    i++;
}
System.Console.WriteLine();