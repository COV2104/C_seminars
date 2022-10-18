// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

int[] ReversArray(int[] array)
{
    int[] reversArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        reversArray[i] = array[size - 1 - i];
    }
    return reversArray;

}

System.Console.WriteLine("Начальный массив: ");
int[] massiv = FillArray();
PrintArray(massiv);
System.Console.WriteLine("развернутый массив: ");
int[] reversMassiv = ReversArray(massiv);
PrintArray(reversMassiv);
