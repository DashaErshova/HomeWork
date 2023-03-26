// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintArray2D(matrix);
Console.WriteLine();

// Sort each row in descending order
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int k = j + 1; k < matrix.GetLength(1); k++)
        {
            if (matrix[i, j] < matrix[i, k])
            {
                // Swap elements if they're out of order
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, k];
                matrix[i, k] = temp;
            }
        }
    }
}

PrintArray2D(matrix);

void PrintArray2D(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write("{0,4}", arr2D[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] CreateMatrixRndInt(int n, int m, int min, int max)
{
    int[,] arr2D = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr2D[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr2D;
}
