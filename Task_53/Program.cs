// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
            array[i, j] = new Random().Next(1, 100);
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

int[,] SortArray(int[,] array)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = array[i, j];
        }
    }
    for (int i = 0; i < columns; i++)
    {
        int temp = newArray[rows - 1, i];
        newArray[rows - 1, i] = newArray[0, i];
        newArray[0, i] = temp;
    }
    return newArray;
}

Console.WriteLine($"Начальный массив {rows} x {columns}:");
int [,] massiv = Fill2DArray(rows,columns);
Print2DArray(massiv);
Console.WriteLine();
Console.WriteLine($"Измененный массив {rows} x {columns}:");
int [,] sortMassiv = SortArray(massiv);
Print2DArray(sortMassiv);