// Напишите программу, которая заполнит спирально массив 4 на 4.

void GetArraySpiral(int[,] array)
{
    int positionI = 0;
    int positionJ = 0;
    bool newSpiral = true;

    for (int i = 0; i < array.Length; i++)
    {
        array[positionI, positionJ] = i + 1;

        if (positionJ + 1 < array.GetLength(1) && newSpiral && array[positionI, positionJ + 1] == 0)
        {
            positionJ++;
            continue;
        }
        else
        {
            newSpiral = false;
        }

        if (positionI + 1 < array.GetLength(0) && array[positionI + 1, positionJ] == 0)
        {
            positionI++;
            continue;
        }

        if (positionJ - 1 >= 0 && array[positionI, positionJ - 1] == 0)
        {
            positionJ--;
            continue;
        }

        if (positionI - 1 >= 0 && array[positionI - 1, positionJ] == 0)
        {
            positionI--;
            continue;
        }
        else
        {
            positionJ++;
            newSpiral = true;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] testArray = new int[4, 4];
GetArraySpiral(testArray);
PrintArray(testArray);