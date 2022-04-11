/*
Задается двухмерный массив, найти медиану каждого столбца
*/

int[,] Generate2DArray(int rowNumber, int colNumber, int deviation)
{
    int[,] arrayToReturn = new int[rowNumber, colNumber];
    for (int i = 0; i < colNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            arrayToReturn[i, j] = new Random().Next(-deviation, deviation);
        }
    }
    return arrayToReturn;
}

void Print2DArray(int[,] incomingArray, string arrayName)
{
    Console.WriteLine($"Вывод массива {arrayName}");
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            Console.Write($"{incomingArray[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("------------------------------------");
}

void PrintArray(int[] incomingArray, string arrayName)
{
    Console.WriteLine($"Вывод массива {arrayName}");
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        Console.Write($"{incomingArray[i]}\t");
    }
    Console.WriteLine();
    Console.WriteLine("------------------------------------");
}

int[] GetRowsMediana(int[,] incomingArray)
{
    int[] medianArray = new int[incomingArray.GetLength(0)];
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        int[] arrayToSort = GetArrayByIndex(incomingArray, i);
        PrintArray(arrayToSort, $"arrayToSort {i}");
        int[] sortedArray = SortArray(arrayToSort);
        PrintArray(sortedArray, $"sortedArray {i}");
        int middleIndex = (int)Math.Ceiling((double)(incomingArray.GetLength(0) / 2));
        if(incomingArray.GetLength(0) % 2 == 0)
        {
            medianArray[i] = (sortedArray[middleIndex] + sortedArray[middleIndex+1]) / 2;
        }
        else
        {
            medianArray[i] = sortedArray[middleIndex];
        }
    }
    return medianArray;
}

int[] GetArrayByIndex(int[,] incomingArray, int index)
{
    int[] returningArray = new int[incomingArray.GetLength(0)];
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        returningArray[i] = incomingArray[index, i];
    }
    return returningArray;
}

int[] SortArray(int[] incomingArray)
{
    bool isSwap = false;
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(0) - i - 1; j++)
        {
            if(incomingArray[i] > incomingArray[i+1])
            {
                int buf = incomingArray[i];
                incomingArray[i] = incomingArray[i+1];
                incomingArray[i+1] = buf;
                isSwap = true;
            }
        }
        if (!isSwap)
        {
            break;
        }
    }
    return incomingArray;
}

int[,] array = Generate2DArray(5, 5, 10);
Print2DArray(array, "Изначальный");
int[] medianArray = GetRowsMediana(array);
PrintArray(medianArray, "Медиана");

