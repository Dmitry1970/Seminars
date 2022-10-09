// Задача 19
// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число:");
int fiveDigit = Math.Abs(Convert.ToInt32(Console.ReadLine()));  // Math.Abs() - в случае, если введут отрицательное число 

if (fiveDigit >= 10000 && fiveDigit < 100000)
    if (FiveDigitNumber(fiveDigit))
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
else
    Console.WriteLine("Введённое число не пятизначное! Введите пятизначное число.");

bool FiveDigitNumber(int number)
{
    bool result = number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10;
    return result;
}

// 2-ой способ(универсальное число)

Console.WriteLine("Введите число:");
int digit = Math.Abs(Convert.ToInt32(Console.ReadLine()));  // Math.Abs() - в случае, если введут отрицательное число 

PalindromDigit(digit);

void PalindromDigit(int dig)
{
    int a = 0;
    int sum = 0;
    int t = 0;
    for (t = dig; dig != 0; dig = dig / 10)
    {
        a = dig % 10;
        sum = sum * 10 + a;
    }
    if (t == sum)
        Console.Write(" -> да");
    else
        Console.WriteLine("-> нет");
}
