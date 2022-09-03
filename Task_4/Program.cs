// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}  ");
    Console.WriteLine();
}

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

int[] ConvertDemensionTwoInOne(int[,] array2)
{
    int[] array1 = new int[array2.GetLength(0) * array2.GetLength(1)];
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array1[i * array2.GetLength(1) + j] = array2[i, j];
        }
    }
    return array1;
}

int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > array[i])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

void CreateFrequenciesDictionary(int[] array)
{
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == array[i - 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{array[i - 1]} встречается {count} раз");
            count = 1;
        }
        if (i == array.Length - 1)
        {
            Console.WriteLine($"{array[i]} встречается {count} раз");
        }
    }
}

// Для одномерного массива

int[] myArray = CreateArray(10, 0, 9);
PrintArray(myArray);
Console.WriteLine();
SortArray(myArray);
PrintArray(myArray);
Console.WriteLine();
CreateFrequenciesDictionary(myArray);
Console.WriteLine();

// Для двумерного массива

int[,] myMatrix = CreateMatrix(3, 4, 0, 9);
PrintMatrix(myMatrix);
Console.WriteLine();
int [] array2 = ConvertDemensionTwoInOne(myMatrix);
PrintArray(array2);
SortArray(array2);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
CreateFrequenciesDictionary(array2);