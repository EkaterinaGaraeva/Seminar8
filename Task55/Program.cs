/*
Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение 
для пользователя.
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

int[,] SwapRowAndColomns(int[,] incomingArray)
{
    int rows = incomingArray.GetLength(0);
    int colomns = incomingArray.GetLength(1);
    int temp = 0;
    if (rows == colomns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < colomns; j++)
            {
                temp = incomingArray[i, j];
                incomingArray[i, j] = incomingArray[j, i];
                incomingArray[j, i] = temp;
            }
        }
    }
    else
    {
        Console.WriteLine("Невозможно заменить строки на столбцы");
    }
    return incomingArray;
}

int[,] array = Generate2DArray(5, 5, 10);
Print2DArray(array, "Изначальный");

int[,] neAarray = SwapRowAndColomns(array);
Print2DArray(array, "Измененный");
