// 18: Напишите программу, которая 
// 1. по заданному номеру четверти, 
// 2. показывает диапазон возможных 
// координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти координатной плоскости:");
string num = Console.ReadLine();

string result = Range(num);
Console.WriteLine(result);

string Range(string number)
{
    if(number == "1") return "x > 0 && y > 0"; 
    if(number == "2") return "x < 0 && y > 0"; 
    if(number == "3") return "x < 0 && y < 0"; 
    if(number == "4") return "x > 0 && y < 0"; 
    return "Ошибка ввода";
}


// 2 способ(switch)

Console.WriteLine("Введите номер четверти координатной плоскости:");
string num1 = Console.ReadLine();

string res = DistanceBetweenDots (num1);
Console.WriteLine(result);

string DistanceBetweenDots(string b)
{
    switch(b)
    {
    case "1": return "x > 0 && y > 0";  
    case "2": return "x < 0 && y > 0";
    case "3": return "x > 0 && y < 0";    
    case "4": return "x > 0 && y > 0";
    default:  return "Ошибка ввода";    
    }
} 

