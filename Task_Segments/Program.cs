// У нас есть график, где даны отрезок 1 - (х1; x2) и отрезок 2 (х3, x4)
// ​Необходимо составить код, который находит их пересечение. 
// Пересечением двух отрезка 1 и 2 могут быть - отрезок, точка или ничего
// С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков, общую точку или «не пересекаются».

Console.Write("Введите начало первого отрезка: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец первого отрезка: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало второго отрезка: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец второго отрезка: ");
int x4 = Convert.ToInt32(Console.ReadLine());

if (x2 == x3) Console.WriteLine($"Точка пересечения равна: {x2}");
else if (x2 <= x4)
{
    if (x3 < x1 && x1 < x4) Console.WriteLine($"Границы пересечения отрезков ({x1},{x2})");
    else if (x3 < x2 && x2 < x4) Console.WriteLine($"Границы пересечения отрезков ({x3},{x2})");
    else Console.WriteLine("Отрезки не пересекаются");
}
else if (x2 > x4)
{
    if (x3 < x1 && x1 < x4) Console.WriteLine($"Границы пересечения отрезков ({x1},{x4})");
    else Console.WriteLine("Отрезки не пересекаются");
}

else Console.WriteLine("Отрезки не пересекаются");
