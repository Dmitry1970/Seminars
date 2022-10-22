// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


// решал самостоятельно

Console.WriteLine("Введите размерность массива:");
int x = Convert.ToInt32(Console.ReadLine());

int[] MyArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[] array)
{
    int[] myArray = new int[array.Length];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = array[i];
    }
    return myArray;
}

int[] arr = MyArray(x, 0, 100);
PrintArray(arr);
int[] myNewArray = CopyArray(arr);
myNewArray[0] = 100;  //- для проверки
PrintArray(myNewArray);



// на семинаре

// int[] Fibonacci(int number)
// {
// int[] array = new int[number];
// array[0] = 0;
// array[1] = 1;
// for (int i = 2; i < number; i++)
// {
// array[i] = array[i - 1] + array[i - 2];
// }
// return array;
// }

// int[] CopyArray(int[] arr)
// {
// int[] newArr= new int[arr.Length];
// for (int i = 0; i < newArr.Length; i++)
// {
// newArr[i]=arr[i];
// }
// return newArr;
// }

// void PrintArray(int[] array)
// {
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
// if (i < array.Length - 1) Console.Write($"{array[i]}, ");
// else Console.Write($"{array[i]}");
// }
// Console.WriteLine("]");
// }

// int[] arr = Fibonacci(num);
// PrintArray(arr);
// int[] newArr = CopyArray(arr);
// PrintArray(newArr);
