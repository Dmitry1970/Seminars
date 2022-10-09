// 11. Напишите программу, которая 
// 1. выводит случайное трёхзначное число и 
// 2. удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число в диапазоне => {number}");

int NumDivision(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    return firstDigit * 10 + secondDigit;
}

int result = NumDivision(number);
Console.WriteLine($"Новое число => {result}");


