// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resultMatrix;
}

Console.WriteLine("Первая матрица:");
int[,] firstMatrix = CreateMatrix(2, 3, 0, 9);
PrintMatrix(firstMatrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
int[,] secondMatrix = CreateMatrix(3, 3, 0, 9);
PrintMatrix(secondMatrix);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц:");
if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
{
    Console.WriteLine("Такие матрицы умножать нельзя!!!");
    return;
}
PrintMatrix(MultiplyMatrix(firstMatrix, secondMatrix));