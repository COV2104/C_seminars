// Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string result = "Неверно введена четверть";
if (quarter == 1) result = "x > 0, y > 0";
else if (quarter == 2) result = "x < 0 , y > 0";
else if (quarter == 3) result = "x < 0 , y < 0";
else if (quarter == 4) result = "x > 0 , y < 0";
Console.WriteLine(result);
