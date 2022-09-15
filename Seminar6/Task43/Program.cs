// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double[,] num = new double[2, 2];
double[] crossPoint = new double[2];

void InputNumbers()
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        Console.WriteLine($"Введите значения {i + 1}-го уравнения (y = k * x + b): ");
        for (int j = 0; j < num.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите значение k: ");
            else Console.Write($"Введите значение b: ");
            num[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Cross(double[,] num)
{
    crossPoint[0] = (num[1, 1] - num[0, 1]) / (num[0, 0] - num[1, 0]);
    crossPoint[1] = crossPoint[0] * num[0, 0] + num[0, 1];
    return crossPoint;
}

void Result(double[,] num)
{
    if (num[0, 0] == num[1, 0] && num[0, 1] == num[1, 1])
    {
        Console.WriteLine($"Прямые совпадают");
    }
    else if (num[0, 0] == num[1, 0] && num[0, 1] != num[1, 1])
    {
        Console.WriteLine($"Прямые параллельны");
    }
    else
    {
        Cross(num);
        Console.WriteLine($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputNumbers();
Result(num);
