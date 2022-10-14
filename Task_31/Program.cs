// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] FillArray()
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 9);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        if (i < size - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.WriteLine($"{array[i]} ]\n");
    }
}

string SumPozitivNegativ(int[] array)
{
    int sumPozitiv = 0;
    int sumNegativ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumPozitiv += array[i];
        else if (array[i] < 0)
            sumNegativ += array[i];
    }
    return $"Сумма положительных чисел равна {sumPozitiv}\nСумма отрицательных чисел равна {sumNegativ}\n";
}

System.Console.WriteLine();
int[] massiv = FillArray();
PrintArray(massiv);
System.Console.WriteLine(SumPozitivNegativ(massiv));
