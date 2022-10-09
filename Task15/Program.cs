// 15. Напишите программу, которая 
// 1.принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// 1 способ

// Console.WriteLine("Введите номер дня недели");
// int numberDayOfWeek = Convert.ToInt32(Console.ReadLine());

// if (numberDayOfWeek >= 1 && numberDayOfWeek <= 5)
//     Console.WriteLine("нет");
// else if (numberDayOfWeek >= 6 && numberDayOfWeek <= 7)
//     Console.WriteLine("да");
// else
//     Console.WriteLine("Введите правильную цифру дня недели от 1 до 7 включительно!");


// 2-й способ(с методом) 

Console.WriteLine("Введите номер дня недели:");
int numberOfWeekDay = Convert.ToInt32(Console.ReadLine());
if (numberOfWeekDay >= 1 && numberOfWeekDay <= 7)
{
    if (CheckDay(numberOfWeekDay)) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
else Console.WriteLine("Введите правильную цифру дня недели от 1 до 7 включительно!");

bool CheckDay(int num)
{
    return num == 6 && num == 7;
}

