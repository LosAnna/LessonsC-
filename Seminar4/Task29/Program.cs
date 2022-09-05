// Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.

int[] InitArray(int size, int numA, int numB)
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(numA, numB);
}
return res;
}

int[] ReadArray(int[] array)
{
int[] res = new int[2];

for (int i = 0; i < array.Length; i++)
{
if (array[i] > 0)
{
res[0] += array[i];
}
else
{
res[1] += array[i];
}

}

return res;
}

Console.WriteLine("Введите число, обозначающее размер массива: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число A: ");
 int numberA  = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB  = int.Parse(Console.ReadLine());

int[] myArray = InitArray(N, numberA, numberB );

Console.WriteLine(String.Join(" ", myArray));
