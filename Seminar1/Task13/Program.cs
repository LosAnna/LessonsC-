// Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = ( num % 1000) / 100;
if(num > 100)
{
    Console.WriteLine($"result: {result}"); 

}
else
{
    Console.WriteLine("Третьей цифры нет.");
}