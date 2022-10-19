// Семинар 6.
// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первое число:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int z = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

bool result = Triangle(x, y, z);
if (result) Console.WriteLine("Да");
else Console.WriteLine("Нет");