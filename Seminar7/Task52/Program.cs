// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return matrix;
}

void ArithmeticMean(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            average = average + array[j, i];
        }
        average = average / array.GetLength(0);
        Console.Write(average + "; ");
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента: ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);
Console.WriteLine();
ArithmeticMean(myArray);

