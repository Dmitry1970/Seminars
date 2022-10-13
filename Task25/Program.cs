// Задача 25: 
// Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// 2-ой способ (метод с возвращаемым типом данных)

Console.WriteLine("Введите первое число:");
int e = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int f = Convert.ToInt32(Console.ReadLine());
int g = Expotent(e, f);
string n = g.ToString();
if (e > 0 && f > 0)
    Console.WriteLine($"Число {e} в степени {f} -> {g}");
else if (e > 0 && f < 0)
    Console.WriteLine($"Число {e} в степени {f} -> 1/{n}");
else if (f == 0)
    Console.WriteLine($"Число {e} в степени {f} -> {g}");
else
    Console.WriteLine("Введите первое число больше 0");

int Expotent(int c, int d)
{
    int summary = c;
    if (d > 0)
        for (int i = 1; i < d; i++)
        {
            summary *= c;
        }
    else if (d < 0)
        for (int i = d; i < -1; i++)
        {
            summary *= c;
        }
    else
    {
        summary = 1;
    }
    return summary;
}


// 1-й способ (метод void) как алтернативный способ

// Console.WriteLine("Введите первое число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine());
// Expotentiation(a, b);


// void Expotentiation(int x, int y)
// {
//    int res = x; 
//    if(x > 0)
//    {
//     if (y > 0)
//     {        
//         for (int i = 1; i < y; i++)
//         {
//             res *= x;
//         }        
//     }
//     else if (y == 0)
//     {
//         res = 1;
//     }

//     else
//     {
//         for (int i = y; i < -1; i++)
//         {
//             res *= x;
//         }
//         string h = res.ToString();
//         Console.WriteLine($"1/{h}");                
//     }
//    Console.WriteLine($"Число {x} в степени {y} => {res}");
//    }
//    else
//    {
//     Console.WriteLine($"Введите первое число {x} больше 0");
//    }
// }











