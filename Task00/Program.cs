// Напишите программу, которая 
// 1. на вход принимает число и выдаёт его квадрат (число
// 2. умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");


// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"Число {a} не является квадратом числа {b}");
}

// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


//1 вариант:

Console.WriteLine("Введите номер дня недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
if (dayOfWeek == 1)
{
    Console.Write($"{dayOfWeek} -> Понедельник");
}
else if (dayOfWeek == 2)
{
    Console.Write($"{dayOfWeek} -> Вторник");
}
else if (dayOfWeek == 3)
{
    Console.Write($"{dayOfWeek} -> Среда");
}
else if (dayOfWeek == 4)
{
    Console.Write($"{dayOfWeek} ->Четверг");
}
else if (dayOfWeek == 5)
{
    Console.WriteLine($"{dayOfWeek} -> Пятница");
}
else if (dayOfWeek == 6)
{
    Console.Write($"{dayOfWeek} -> Суббота");
}
else if (dayOfWeek == 7)
{
    Console.Write($"{dayOfWeek} -> Воскресенье");
}
else
{
    Console.WriteLine($"Такого дня недели {dayOfWeek} - не существует");
}

// 2-ой вариант

Console.WriteLine("Введите номер: ");
int dayOfWeek1 = Convert.ToInt32(Console.ReadLine());
switch (dayOfWeek1)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine($"Такого номера - {dayOfWeek1} дня недели не существует");
        break;
}

