// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
//  и выдаёт номер строки с наименьшей суммой элементов: 1 строка



    int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
    PrintArray2D(matrix);
    int minRow = FindRowWithMinSum(matrix);
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");


int[,] CreateMatrixRndInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }

    return matrix;
}

void PrintArray2D(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }

        Console.WriteLine();
    }
}

int FindRowWithMinSum(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);
    int minSum = int.MaxValue;
    int minRow = -1;

    for (int i = 0; i < rowCount; i++)
    {
        int sum = 0;

        for (int j = 0; j < colCount; j++)
        {
            sum += matrix[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }

    return minRow + 1;
}
