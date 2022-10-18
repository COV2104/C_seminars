// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// 1 вариант:

Console.Write("Введите количество необходимых чисел Фибоначчи: ");
int num = Convert.ToInt32(Console.ReadLine());

int fibonacci = 0;
int fibonacci2 = 1;
Console.Write($"Первые {num} чисел Фибоначчи: ");
for (int i = 0; i < num; i++)
{
    Console.Write($"{fibonacci} ");
    int temp = fibonacci;
    fibonacci = fibonacci2;
    fibonacci2 += temp;
}
Console.WriteLine();

// 2 вариант:

Console.Write("Введите количество необходимых чисел Фибоначчи: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] fib = new int[n];


for (int i = 2; i < n; i++)
{
    fib[0] = 0;
    fib[1] = 1;
    fib[i] = fib[i - 1] + fib[i - 2];
}
for (int i = 0; i < n; i++)
{
    Console.Write($"{fib[i]} ");
}
Console.WriteLine();