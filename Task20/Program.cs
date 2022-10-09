// 20. Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double d = 5.09997676;
// double resD = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(resD);


Console.WriteLine("Введите координаты первой точки:");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());


double distance = Math.Round(DistanceBetweenDots(x1, y1, x2, y2), 2, MidpointRounding.ToZero);
Console.WriteLine(distance);


double DistanceBetweenDots(int a1, int b1, int a2, int b2)
{
    double distance = Math.Sqrt(Math.Pow((a2-a1), 2) + Math.Pow((b2 - b1),2));
return distance;
}






