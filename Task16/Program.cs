// 16. Напишите программу, которая 
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Console.WriteLine("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// bool CheckingNumbers(int number1, int number2)
// {
//     int min = number1;
//     int max = number2;
//     if (number1 > number2)
//     {
//         min = number2;
//         max = number1;       
//     }

//    return min * min == max;
// }

// bool result = CheckingNumbers(num1, num2);
// if (result) Console.WriteLine("да");
// else Console.WriteLine("нет");

// 2-й способ

Console.WriteLine("Введите первое число:");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondDigit = Convert.ToInt32(Console.ReadLine());

bool CheckSquare(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}

if(CheckSquare(firstDigit, secondDigit)) Console.Write("да"); 
else Console.Write("нет");