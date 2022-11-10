// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.Write("Введите количество строк теугольника Паскаля: ");
int rows = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < rows; i++)
{
    int number = 1;
    for (int j = 0; j < rows-i; j++)
    {
        Console.Write("   ");
    }
    for (int k = 0; k <= i; k++)
    {
        Console.Write($"   {number}  ");
        number = number * (i - k) / (k + 1);
    }
    Console.WriteLine();
}