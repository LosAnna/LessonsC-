// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
    {
        Console.WriteLine("Да, чётное");
    }
else   
    {
        Console.WriteLine("Нет, нечётное");
    }