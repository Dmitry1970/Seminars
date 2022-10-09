// 13. Напишите программу, которая 
// 1. выводит третью цифру заданного числа
// 2. или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// 1 способ(без метода)

Console.WriteLine("Введите число");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

while (number > 999)
{
    number = number / 10;

}
if (number > 99 && number < 1000)
{
    Console.WriteLine($" -> {number % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


// 2 способ (с методом)

Console.WriteLine("Введите число");
int number1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result = ThirdDigit(number1);
if (number1 > 99) Console.WriteLine(result);
else Console.WriteLine("Третьей цифры нет");



int ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}
