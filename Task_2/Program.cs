// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrix(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void GetMinSumRow(int[,] matrix)
{
    int row = 0;
    int minSumRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        minSumRow += matrix[0, i];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (minSumRow > sum)
        {
            minSumRow = sum;
            row = i;
        }
    }
    Console.WriteLine($"{row + 1} - строка с наименьшей суммой элементов = {minSumRow}.");
}

int[,] myMatrix = CreateMatrix(4, 4, 0, 9);
PrintMatrix(myMatrix);
Console.WriteLine();
GetMinSumRow(myMatrix);