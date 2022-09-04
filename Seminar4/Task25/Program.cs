//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int RaiseToPow(int numA, int numB)
{
    int result = 1;
    if (numB > 0)
    {
        for (int i = 1; i <= numB; i++)
        {
            result *= numA;
        }
    }    
    return result;
}

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine($"{RaiseToPow(numberA, numberB)}");