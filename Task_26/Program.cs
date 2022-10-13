// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int count = 0;
while (number1 > 0)
{
    number1 = number1 / 10;
    count++;
}
System.Console.WriteLine($"Количество цифр в числе = {count}");
