// // Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Наименьший элемент - 1, на выходе получим следующий массив:

// 9 4 2
// 2 2 6
// 3 4 7

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

int[] FindMinElementMatrix(int[,] matrix)
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < matrix[minI, minJ])
            {
                minI = i;
                minJ = j;
            }
        }
    }
    int[] minArray = new int[] {minI, minJ};
    return minArray;
}

void PrintNewMatrix(int[,] array, int minI, int minJ)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != minI && j != minJ)  Console.Write($"{array[i,j]}\t");  
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 4, 0, 9);
PrintMatrix(matrix);
int[] minArray = FindMinElementMatrix(matrix);
int minI = minArray[0];
int minJ = minArray[1];
Console.WriteLine();
Console.WriteLine($"Минимальный элемент имеет индекс: ({minI}, {minJ})");
Console.WriteLine();
PrintNewMatrix(matrix, minI, minJ);