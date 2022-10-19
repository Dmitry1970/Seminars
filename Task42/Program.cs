// Семинар 6
// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// можно решить с помощью рекурсии



Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());

int BinaryDigit(int a)
{
    int result = 0;
    int count = 1;
    while (a > 0)
    {
        result += a % 2 * count;
        a /= 2;
        count = count * 10;
    }
    return result;
}

int c = BinaryDigit(x);
Console.WriteLine(c);


// решение на семинаре(через строку)

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string DecToBin(int number)
// {
//     string result = String.Empty;
//     while (number > 0)
//     {
//         result = Convert.ToSingle(number % 2) + result;
//         number = number / 2;
//     }
//     return result;
// }

// string decToBin = DecToBin(num);
// Console.WriteLine(decToBin);

