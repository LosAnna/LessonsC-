// Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, 
//и возвращает индексы этого элемента или же указание, что такого элемента нет.

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10 + 1);
        }
    }

    return matrix;
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

int m = 3;
int n = 4;
int[,] myArray = GetArray(m, n);
PrintArray(myArray);

Console.WriteLine("Введите число: ");
int item = int.Parse(Console.ReadLine());
string SearchPosition(int[,] array)
{
    string result = string.Empty;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (item == array[m, n]) result += $"({m}, {n})";
        }
    }
    if (result == string.Empty) result = "-> такого элемента нет";
    return result;
}
Console.WriteLine(SearchPosition(myArray));


