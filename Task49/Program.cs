// Семинар 7
// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

Console.WriteLine("Введите количество строк:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int y = Convert.ToInt32(Console.ReadLine());



int[,] CreateMatrix(int a, int b, int min, int max)
{
    int[,] myMatrix = new int[a, b];
    Random rnd = new Random();

    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            myMatrix[i, j] = rnd.Next(min, max);
        }
    }
    return myMatrix;
}

int[,] ChangeEvenIndexNumbers(int[,] myNewMatrix)
{
    for (int i = 0; i < myNewMatrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < myNewMatrix.GetLength(1); j += 2)
        {
            myNewMatrix[i, j] *= myNewMatrix[i, j];
        }
    }
    return myNewMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
            {
                Console.Write($"{matrix[i, j],4} ,");
            }
            else
            {
                Console.Write($"{matrix[i, j],4}");
            }
        }
        Console.WriteLine("]");
    }
}

int[,] myMyMatrix = CreateMatrix(x, y, 0, 10);
PrintMatrix(myMyMatrix);
int[,] newNewMatrix = ChangeEvenIndexNumbers(myMyMatrix);
Console.WriteLine();
PrintMatrix(newNewMatrix);
