// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Console.WriteLine("Введите размерность массива:");
// int number = Convert.ToInt32(Console.ReadLine());

// я решал

int[] MultiplyArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {

        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write($"{arr[arr.Length - 1]}");
        }
    }
    Console.Write("]");
}

int[] NewArray(int[] array)
{
    
    int newSize = array.Length / 2;
    if(array.Length % 2 != 0)  
    newSize = newSize + 1;
    int[] newArr = new int[newSize];
    {   
        for (int i = 0; i < newArr.Length; i++)
        {
        newArr[i] = array[i] * array[array.Length - 1 - i];
        }    
    }
    if  (array.Length % 2 != 0) 
         newArr[newSize -1] = array[newSize - 1];        
    return newArr;
}

int[] myArray = MultiplyArray(7, 0, 20);
PrintArray(myArray);
Console.WriteLine();
int[] newMyArray = NewArray(myArray);
PrintArray(newMyArray);

// решали на семинаре

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     var rnd = new Random(); 
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }

// int[] NewArray(int[] array)
// {
//     int size = array.Length / 2;
//     if (array.Length % 2 == 1) size = size + 1;
//     int[] newArr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         newArr[i] = array[i] * array[array.Length - 1 - i];
//     }
//     if (array.Length % 2 == 1) newArr[size-1] = array[size-1];
//     return newArr;
// }

// int[] arr = CreateArrayRndInt(5, 0, 10);
// PrintArray(arr);

// int[] newArray = NewArray(arr);
// PrintArray(newArray);





// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     var array = new double[size];
//     var rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         double rndNum = rnd.NextDouble() * (max - min) + min;
//         array[i] = Math.Round(rndNum, 2);

//     }
//     return array;
// }
// void PrintArrayDouble (double[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }
