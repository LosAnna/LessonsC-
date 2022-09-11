// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] NewArray()
{
    double[] arr = new double[10];

    for (int i = 0; i < arr.Length; i++)
    {
        //arr[i] = new Random().NextDouble() * 100;
        arr[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return arr;
}

double MinMaxDif(double[] array)
{
    double maxEl = array[0];
    double minEl = array[0];
    
    for (int i = 1; i < array.Length; i++)
    {
        if (maxEl < array[i])
        {
            maxEl = array[i];
        }
         if (minEl > array[i])
        {
            minEl = array[i];
        }
    }
    double result = maxEl - minEl;
    return result;
}

double[] myArray = NewArray();
double Dif = MinMaxDif(myArray);

Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine($"Разница между максимальным и минимальным элементами: {Dif}");





