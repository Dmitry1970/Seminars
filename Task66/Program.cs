// Практическое задание 9

// Задайте значения М и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

Console.Write("Введите первое значение: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе значение: ");
int number2 = Convert.ToInt32(Console.ReadLine());


int SumOfNaturalElements(int startNumber, int finishNumber)
{
    if (finishNumber == startNumber) return startNumber;
    if (startNumber < finishNumber)
    {
        return startNumber + SumOfNaturalElements(startNumber + 1, finishNumber);
    }
    return startNumber + SumOfNaturalElements(startNumber - 1, finishNumber);
}

int result = SumOfNaturalElements(number1, number2);
Console.WriteLine(result);