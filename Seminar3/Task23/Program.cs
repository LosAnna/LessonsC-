// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N ");
int numN = int.Parse(Console.ReadLine());
int count = 1;
for (int i = 1; i<=numN; i++)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
}
Console.WriteLine();