// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] Fill2DArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
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

int[,] FillNew2DArray(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i > 0 && i % 2 == 0 && j > 0 && j % 2 == 0)
                newArray[i, j] = array[i, j] * array[i, j];
            else
                newArray[i, j] = array[i, j];
        }
    }
    return newArray;
}

int[,] massiv = Fill2DArray(rows, columns);
Console.WriteLine($"Двумерный массив {rows} x {columns} :");
Print2DArray(massiv);
int[,] newMassiv = FillNew2DArray(massiv);
Console.WriteLine($"Измененный массив {rows} x {columns} :");
Print2DArray(newMassiv);
