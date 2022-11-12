// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

System.Console.WriteLine("Введите число N: ");
int n =  Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число M: ");
int m =  Convert.ToInt32(Console.ReadLine());

if(m > n)
    {
       int temp = m;
        m = n;
        n = temp;
    }

void PrintMN(int m, int n)
{
    if(m <= n)
    {
        Console.Write($"{m} ");
        PrintMN(m + 1, n);
    }

}

PrintMN(m, n);
Console.WriteLine();
