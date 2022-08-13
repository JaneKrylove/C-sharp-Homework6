// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double CrossPoint1(double x1, double y1, double x2, double y2)
{
    
    double a = 0;
    a = (x2 - x1) / (y1 - y2);
    

    return a;
}

double CrossPoint2(double x1, double y1, double x2, double y2)
{
    double b = 0;

    b = ((x1-x2))/(y2-y1);

    return b;
}

Console.WriteLine("Input x1: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y1: ");
double m1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input x2: ");
double n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y2: ");
double m2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Intersection point is: " + (CrossPoint1(n1, m1, n2, m2) + ";" +CrossPoint2(n1, m1, n2, m2)));