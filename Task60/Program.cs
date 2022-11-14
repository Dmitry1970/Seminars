// Практическое задание 8

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine("Задайте трёхмерный массив:");
Console.Write("Введите первое измерение: ");
int firstDim = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе измерение: ");
int secondDim = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье измерение: ");
int thirdDim = Convert.ToInt32(Console.ReadLine());
CreateThreeDimesionMatrix(firstDim, secondDim, thirdDim);
int numbers = firstDim * secondDim * thirdDim;
int[] arr = FillArray(numbers);
PrintArray(arr);




int[,,] CreateThreeDimesionMatrix(int row, int column, int depth)
{
    int[,,] matrix = new int[row, column, depth];
    int numbers = row * column * depth;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($" {matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    return matrix;
}

int[] FillArray(int numb)
{
    int[] array = new int[numb];
    int startNumber = 10;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = startNumber++;
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
            Console.Write($"{array[i],2}, ");
        }
        else
        {
            Console.Write($"{array[i],2}");
        }
    }
    Console.WriteLine("]");
}
