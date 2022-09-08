// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int SumElements(int[] array)
{
    int result = 0;
    for (int i = array.Length - 1 - (array.Length & 1); i >= 0; i -= 2)
    {
        result = result + array[i];
    }
    return result;    
}

int[] myArray = GetArray(10, 10, 100);
Console.WriteLine(String.Join(" ", myArray));

int result = SumElements(myArray);
Console.WriteLine($"{(result)}");