// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] FillArray()
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.WriteLine($"{array[i]} ]\n");
    }
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;

}

System.Console.WriteLine("Начальный массив: ");
int[] massiv = FillArray();
PrintArray(massiv);
System.Console.WriteLine("Скопированный массив: ");
int[] reversMassiv = CopyArray(massiv);
PrintArray(reversMassiv);



