// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);

double[] columnSums = GetColumnSums(array2d);

Console.Write("Среднее арифметическое каждого столбца: ");

for (int i = 0; i < columnSums.Length; i++)
{
    double columnAverage = columnSums[i] / array2d.GetLength(0);
    Console.Write($"{columnAverage:F2} ");

}

Console.WriteLine();

int[,] CreateMatrixRndInt(int numRows, int numCols, int minValue, int maxValue)
{
    int[,] matrix = new int[numRows, numCols];
    Random rnd = new Random();

    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numCols; j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);

    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numCols; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }

        Console.WriteLine();
    }
}

 double[] GetColumnSums(int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);

    double[] columnSums = new double[numCols];

    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numCols; j++)
        {
            columnSums[j] += array[i, j];
        }
    }

    return columnSums;
}