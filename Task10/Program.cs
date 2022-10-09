// 10. Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// 1  способ

Console.WriteLine("Введите трехзначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number > 99 && number < 1000)
{
    Console.WriteLine($" -> {Math.Abs(number / 10) % 10}");
}
else
{
    Console.Write("Введённое число не трехзначное. Введите трехзначное число.");

}


// 2-й способ(метод)

Console.WriteLine("Введите трехзначное число: ");
int threeDigitNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if(CheckRange(threeDigitNumber))
Console.WriteLine($"-> {SecondDigit(threeDigitNumber)}");
else Console.WriteLine("Введённое число не трехзначное. Введите трехзначное число.");


bool CheckRange (int digit)
{
    return digit > 99 && digit < 1000;
}

int SecondDigit(int num)
{
    return num / 10 % 10; 
}



