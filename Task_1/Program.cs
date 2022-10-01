// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли 
// первое число квадратом второго.
// a = 25, b = 5 -> да 

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 == number1*number1 ) Console.WriteLine($"Число {number2} является квадратом числа {number1}");
else if (number1 ==number2* number2) Console.WriteLine($"Число {number1} является квадратом числа {number2}");
else Console.WriteLine($"Числа не являются квадратами друг друга");
