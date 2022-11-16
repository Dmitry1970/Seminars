// Практическое задание 9

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Введите число m: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AkkermanFunction(m - 1, 1);
    }
            return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));    
}

int result = AkkermanFunction(number1, number2);
Console.WriteLine($"A(m,n) = {result}");