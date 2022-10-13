// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] FillArray()
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        if (i < size - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.WriteLine($"{array[i]}");
    }
}

int[] massiv = FillArray();
int[] nas = FillArray();
int[] mas = FillArray();
PrintArray(massiv);
PrintArray(nas);
PrintArray(mas);

