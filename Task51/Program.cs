// Семинар 7
// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int[,] CreateMatrix(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j < newMatrix.GetLength(1) - 1)
            {
                Console.Write($"{newMatrix[i, j]}, ");
            }
            else
            {
                Console.Write($"{newMatrix[i, j]}");
            }
        }
        Console.WriteLine("]");
    }
}

int SumOfElements2(int[,] array2d)
{
    int sum = 0;
    int dimension = 0;
    if (array2d.GetLength(0) > array2d.GetLength(1))  
    {
        dimension = 1;
    }
    for (int i = 0; i < array2d.GetLength(dimension); i++)
    {
        sum += array2d[i, i];

    }
    return sum;
}

int SumOfElements(int[,] array2d)
{
    int sum = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array2d[i, j];
            }
        }        
    }
    return sum;
}

int[,] myMatrix = CreateMatrix(4, 5, 1, 10);
PrintMatrix(myMatrix);
Console.WriteLine();

int x = SumOfElements2(myMatrix);
Console.WriteLine(x);
