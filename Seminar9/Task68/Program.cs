// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 & n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else if (m > 0 & n > 0)
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }

    return 0;
}

Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("A(m,n) = ");
Console.WriteLine(FunctionAkkerman(numberM, numberN));