// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumFromMtoN(int numberM, int numberN)
{
    if (numberM == numberN)
    {
        return numberM;
    }
    else if (numberM > numberN)
    {
        return numberM + SumFromMtoN(numberM - 1, numberN);
    }
    else
    {
        return numberM + SumFromMtoN(numberM + 1, numberN);
    }
}

Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumFromMtoN(numberM, numberN));