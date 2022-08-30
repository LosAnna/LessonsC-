// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int num1 = ( num % 100000) / 10000;
int num2 = ( num % 10000) / 1000;
int num3 = ( num % 100) / 10;
int num4 = num % 10;

if (num1 == num4 && num2 == num3)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}