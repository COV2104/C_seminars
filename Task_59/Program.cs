// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
//  на пересечении которых расположен наименьший элемент массива.

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] Fill2DArray()
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 21);
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

int [,] DelRowsColumns(int[,] array)
{
    int min = array[0, 0];
    int minRows = 0;
    int minColumns = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minRows = i;
                minColumns = j;
            }
        }
    }
    Console.WriteLine($"минимальное значение = {min}");
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0, l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (minRows != i && minColumns != j)
            {
                newArray[k, l] = array[i, j];
                l++;
            }
        }
        l =0;
        if (minRows != i) k++;
    }
    return newArray;
}

Console.WriteLine($"Начальный массив {rows} x {columns}: ");
int[,] massiv = Fill2DArray();
Print2DArray(massiv);
Console.WriteLine($"Измененный массив {rows-1} x {columns-1}: ");
int [,] newMassiv = DelRowsColumns(massiv);
Print2DArray(newMassiv);
