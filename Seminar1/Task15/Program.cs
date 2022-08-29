// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру от 1-7, обозначающую день недели: ");
int day = int.Parse(Console.ReadLine());
if (0 < day && day < 8)
{
    if (day == 1) Console.WriteLine("Нет");
    else if (day == 2) Console.WriteLine("Нет");
    else if (day == 3) Console.WriteLine("Нет");
    else if (day == 4) Console.WriteLine("Нет");
    else if (day == 5) Console.WriteLine("Нет");
    else if (day == 6) Console.WriteLine("Да");
    else if (day == 7) Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Введён не правильный день недели");
}