// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    for (int i = 2; i <= number; i += 2)
    {
        if (i < number - 1)
        {
            Console.Write(i + ", ");
        }
        else
        {
            Console.Write(i);
        }
    }
}
else
{
    Console.WriteLine("Введите число больше 0");
}












