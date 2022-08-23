Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("{0} Наибольшее число", number1);
}
else
{
    Console.WriteLine("{0} Наибольшее число", number2);
}
Console.WriteLine("Наибольшее число");