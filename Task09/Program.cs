// 9. Напишите программу, которая выводит
// 1. случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 10 включено, 100 - не включено, т.е. диапазон от 10 до 99
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");
// int firstDigit = number / 10;  // 78 / 10 = 7
// int secondDigit = number % 10; // 78 % 10 = 8
// if(firstDigit == secondDigit) Console.WriteLine ("Цифры равны");
// else if (firstDigit > secondDigit) Console.WriteLine ($"Наибольшая цифра числа = {firstDigit}");
// else Console.WriteLine ($"Наибольшая цифра числа = {secondDigit}");


// решение с методом

int MaxDigit(int num)
{
    int firstDigit = num / 10;  // 78 / 10 = 7
    int secondDigit = num % 10; // 78 % 10 = 8  

    // int result = default;

    // if (firstDigit > secondDigit) result = firstDigit;
    // else result = secondDigit;

    //если(if)        тогда   то           иначе(else)
    return firstDigit > secondDigit ? firstDigit : secondDigit; // тернарный оператор ;
}

int maxDigit = MaxDigit(number);

Console.WriteLine($"Наибольшая цифра числа = {maxDigit}");

// 2-ой вариант
// int res = Math.Max(firstDigit, secondDigit);
// Console.WriteLine ($"Наибольшая цифра числа = {res}");