// 12. Напишите программу, которая 
// 1.будет принимать на вход два числа и 
// 2. выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// 1 способ (без метода)

if(num2 > num1)
{
    if (num2 % num1 == 0)
    {
                 Console.Write($"кратно");
    }
    else  
    {
        Console.Write($"не кратно - остаток -> {num2 % num1}");
    }
}
else 
{
    Console.WriteLine("Первое число больше второго");
}



