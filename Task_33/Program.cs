// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
    for (int i = 0; i < size; i++)
    {
        if (i < size - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.WriteLine($"{array[i]} ]\n");
    }
}

string FindNumberArray(int[] array)
{
    Console.Write("Введите число для поиска ");
    int findNumber = Convert.ToInt32(Console.ReadLine());
    string result = $"Число отсутствует в массиве\n";
    bool find = false;
    foreach (int item in array)
    {
        if (item == findNumber)
        {
            find = true;
            break;
        }
    }
    if (find)
        result = $"Число присутствует в массиве\n";

    return result;
}

int[] massiv = FillArray();
PrintArray(massiv);
System.Console.WriteLine(FindNumberArray(massiv));
