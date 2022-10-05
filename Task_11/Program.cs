// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46

int number = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировали случайное число: {number}");

int number1 = number / 100;
int number3 = number % 10;
int newNumber = number1 * 10 + number3;

Console.WriteLine($"Новое двухзначное число: {newNumber}");