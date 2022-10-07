// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите значение координаты x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты y: ");
int y = Convert.ToInt32(Console.ReadLine());

int result = 0;

if (x > 0 && y > 0) result = 1;
else if (x < 0 && y > 0) result = 2;
else if (x < 0 && y < 0) result = 3;
else if (x > 0 && y < 0) result = 4;
else Console.WriteLine("Точка лежит на оси координат");

System.Console.WriteLine($"Точка лежит в {result} четверти");
