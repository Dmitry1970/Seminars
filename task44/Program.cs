// Семинар 6.
// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// моё решение

Console.WriteLine("Введите число Фибоначчи:");
int f = Convert.ToInt32(Console.ReadLine());

void Fibonacci(int x)
{
    int a = 0;
    Console.Write($"{a} ");
    int b = 1;
    Console.Write($"{b} ");
    int c = 0;   
    for(int i = 2; i < x; i++)
    {        
        c = a + b;       
        Console.Write($"{c} ");
        a = b;
        b = c;
    }    
}

Fibonacci(f);


// на семинаре:


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] Fibonacci(int number)
// {
//     int[] array = new int[number];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < number; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }

// int[] arr = Fibonacci(num);
// PrintArray(arr);




