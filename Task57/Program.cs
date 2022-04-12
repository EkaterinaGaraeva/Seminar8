/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/

int[,] Generate2DArray(int rowNumber, int colNumber, int deviation)
{
    int[,] arrayToReturn = new int[rowNumber, colNumber];
    for (int i = 0; i < colNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            arrayToReturn[i, j] = new Random().Next(0, deviation);
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

int[,] GetFrequencyArrayNumbers(int[,] incomingArray)
{
    int[,] arrayOfNumbers = new int[10, 2];
    int count = 0;
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            
        }
        return arrayOfNumbers;
    }

    int[,] array = Generate2DArray(5, 5, 9);
    Print2DArray(array, "Изначальный");

    int[,] newArray = GetFrequencyArrayNumbers(array);
    Print2DArray(newArray, "Счет");

