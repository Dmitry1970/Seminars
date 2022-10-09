// 14. Напишите программу, которая
// 1. принимает на вход число и 
// 2. проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// 1-ый метод (более универсальный)

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите делитель 1: ");
int divider1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите делитель 2: ");
int divider2 = Convert.ToInt32(Console.ReadLine());


bool CheckingNumber(int number, int div1, int div2)
{
    return number % div1 == 0 && number % div2 == 0;
}

bool result = CheckingNumber(num1, divider1, divider2);
if (result)
{
    Console.Write("да");
}
else 
{
    Console.Write("нет");
}


// 2-ой метод

// Console.WriteLine("Введите первое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool Remains(int a, int b)
// {
//     return a % b == 0;     
// }

// if(Remains(number, 7) && Remains(number, 23)) Console.Write("да");
// else Console.Write("нет");