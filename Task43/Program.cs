// Домашнее задание 6
// Задача 43: 
// Напишите программу, которая 
// 1. найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// 1 способ(без передачи в параметры метода)

Console.WriteLine("Введите значение b1:");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k1:");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

double FindX()
{
    double x = 0;
    return x = (b2 - b1) / (k1 - k2);
}

double FindY()
{
    double x = FindX();
    double y = 0;

    y = k1 * x + b1;
    return y;
}

double g = FindX();
Console.Write($"({g}; ");
double d = FindY();
Console.WriteLine($"{d})");


// 2 способ(передача данных в параметры метода)

// Console.WriteLine("Введите значение b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите значение k1:");
// double k1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите значение b2:");
// double b2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите значение k2:");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double FindX(double b1, double k1, double b2, double k2)
// {
//     double x = 0;
//     return x = (b2 - b1) / (k1 - k2);
// }

// double FindY(double b1, double k1, double b2, double k2)
// {
//     double x = FindX(b1, k1, b2, k2);
//     double y = 0;

//     y = k1 * x + b1;
//     return y;
// }

// double g = FindX(b1, k1, b2, k2);
// Console.Write($"({g}; ");
// double d = FindY(b1, k1, b2, k2);
// Console.WriteLine($"{d})");