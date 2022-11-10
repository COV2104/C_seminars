// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон значеий для заполнения массива: ");
Console.Write("От: ");
int randomStart = Convert.ToInt32(Console.ReadLine());
Console.Write("До: ");
int randomEnd = Convert.ToInt32(Console.ReadLine());

int[,] Fill2DArray()
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Dictionary(int[,] array)
{

    for (int num = randomStart; num <= randomEnd; num++)
    {
        int count = 0;
        foreach (int i in array)
        {
            if (num == i)
            {
                count++;
            }
        }
        if (count > 0)
        {
            Console.WriteLine($"Значение {num} встречается {count} раз");
        }
    }

}

int[,] massiv = Fill2DArray();
Print2DArray(massiv);
Dictionary(massiv);

