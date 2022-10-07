// 10. Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// 1  способ

Console.WriteLine("Ведите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    Console.WriteLine((number / 10) % 10);
}
else
{
    Console.WriteLine("Введённое число не трехзначное. Введите трехзначное число.");

}


// 2-й способ(метод)

Console.WriteLine("Введите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SecondDigit(threeDigitNumber));


int SecondDigit(int num)
{
    return num > 99 && num < 1000 ? (num / 10) % 10 : -1;  // -1 - в случае, если число вне диапазона
}



