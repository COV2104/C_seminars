// Задача 21: Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

Console.Write("Введите значение координаты x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

int sum = ((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1));
double distance = Math.Round(Math.Sqrt(sum),2);

System.Console.WriteLine($"Расстояние между точками = {distance}");
