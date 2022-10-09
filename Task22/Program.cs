// 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
SquareDigit(n);

void SquareDigit(int x)
{
    int index = 1;
    while(index <= x)    
    {
        Console.WriteLine($"|{index, 4}|{Math.Pow(index, 2), 4}|");
        index ++;
    }    
}


// 2 способ(через цикл for)

// void SquareDigit(int x)
// {
//     for(int i = 1; i <= x; i++)
//         Console.WriteLine($"|{i, 4}|{Math.Pow(i, 2), 4}|");
// }