/*
Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
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

int[,] SwapColumns(int[,] incomingArray)
{
    int temp = 0;
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        temp = incomingArray[0, i];
        incomingArray[0, i] = incomingArray[incomingArray.GetLength(0) - 1, i];
        incomingArray[incomingArray.GetLength(0) - 1, i] = incomingArray[0, i];
    }
    return incomingArray;
}

int[,] array = Generate2DArray(5, 5, 10);
Print2DArray(array, "Изначальный");

int[,] newArray = SwapColumns(array);
Print2DArray(newArray, "Измененный");


