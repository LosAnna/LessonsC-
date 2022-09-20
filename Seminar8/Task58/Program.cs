// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void GetArray(int[,] array, int[,] array1)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10 + 1);
        }
    }
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(1, 10 + 1);
        }
    }
}

void PrintArray(int[,] array, int[,] array1)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GenerationMatrix(int[,] array, int[,] array1, int[,] generatMatr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            generatMatr[i, j] = array[i, j] * array1[i, j];
        }
    }
}

void PrintGeneration(int[,] generatMatr)
{
    for (int i = 0; i < generatMatr.GetLength(0); i++)
    {
        for (int j = 0; j < generatMatr.GetLength(1); j++)
        {
            Console.Write($"{generatMatr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[2, 2];
int[,] matrix1 = new int[2, 2];
int[,] generatMatr = new int[2, 2];
GetArray(matrix, matrix1);
PrintArray(matrix, matrix1);
Console.WriteLine();
GenerationMatrix(matrix, matrix1, generatMatr);
PrintGeneration(generatMatr);
