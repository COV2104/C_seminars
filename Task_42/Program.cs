// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// 1 вариант :

Console.Write("Введите десятичное число: ");
int number10 = Convert.ToInt32(Console.ReadLine());
string numberT = "";
while (number10 > 0)
{
    numberT = (number10 % 2) + numberT;
    number10 /= 2;
}
Console.WriteLine(numberT);

// 2вариант:

System.Console.Write("Введите десятичное число: ");
int num10 = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
List<int> listNum2 = new List<int>();
while (num10 > 0)
{
    num2 = num10 % 2;
    num10 = num10 / 2;
    listNum2.Add(num2);
}
for (int i = listNum2.Count - 1; i >= 0; i--)
{
    Console.Write(listNum2[i]);
}
Console.WriteLine();


