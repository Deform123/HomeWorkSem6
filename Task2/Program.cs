// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
 

if (k1 * b2 == k2 * b1) 
    Console.WriteLine("Прямые не пересекаются!");
else
{ 
    double x = -(b1 - b2) / (k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    Console.WriteLine($"Точка перечечения линий: ({y1};{y2})");
}