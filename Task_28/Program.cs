// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string ProduktNumber(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        prod = prod * i;
    }
    return $"Произведение чисел = {prod}";
}
System.Console.WriteLine(ProduktNumber(number));
