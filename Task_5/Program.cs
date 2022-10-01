// Задача 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает
// все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int nOdd = -n;
while (nOdd <= n)
{
    Console.Write($"{nOdd}, ");
    nOdd++;
}
Console.WriteLine();