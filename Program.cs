// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Ввидите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double n = (b1 - b2);
double m = (k2 - k1);
double x = n / m;
double y = k2 * x + b2;

Console.WriteLine("Координаты по оси Х:" + x);
Console.WriteLine("Координаты по оси Y:" + y);