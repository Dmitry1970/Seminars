// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


// int[] mas = { 1, 2, 5, 7, 19, 6, 1, 33 };
// PrintArray(mas);

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//         if (i < array.Length - 1)
//         {
//             Console.Write(", ");
//         }
//     }
// }

// 2 способ

// Console.WriteLine("Введите размерность массива:");
// int number = Convert.ToInt32(Console.ReadLine());
//  int[] array = new int[number];

// int[] FillArray(int[] arr, int num)
// {   
//     Random rnd = new Random();   
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(1, 41);        
//     }
//      return arr;
// }
// void PrintArray(int[] array)
// {
//     Console.Write($"[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}");   
//         if(i < array.Length - 1)
//         Console.Write(", ");

//     }
//     Console.Write($"]");
// }

// int [] myArray = FillArray(array, number);
// PrintArray(myArray);



// 3-ий способ

// Console.WriteLine("Введите размерность массива:");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[number];
// Random rnd = new Random();

// Console.Write($"[");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next(1, 41);
//     Console.Write($"{array[i]}");
//     if (i < array.Length - 1)
//         Console.Write(", ");
// }
// Console.Write($"]");


// 4 метод

Console.WriteLine("Введите размерность массива:");
int number = Convert.ToInt32(Console.ReadLine());
int[] arra = new int[number];

int[] FillArray(int[] array, int num)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 41);
    }
    return array;
}
void PrintArray(int[] arr)
{
   Console.Write($"[");   
   for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    if (i < arr.Length - 1)

        Console.Write(", ");
}
Console.Write($"]");
}

int [] myArray = FillArray(arra, number);
PrintArray(myArray);




