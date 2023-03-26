// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintArray2D(matrix);
ReplaceFirstLastRows(matrix);
Console.WriteLine();
PrintArray2D(matrix);


void ReplaceFirstLastRows(int[,] arr2D)
{
    int firstRowIndex = 0;
    int lastRowIndex = arr2D.GetLength(0) - 1;
    for (int i = 0; i < arr2D.GetLength(1); i++)
    {
        int temp = arr2D[firstRowIndex, i];
        arr2D[firstRowIndex, i] = arr2D[lastRowIndex, i];
        arr2D[lastRowIndex, i] = temp;
    }
}


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] arr2D = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr2D;
}

void PrintArray2D(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write($"{arr2D[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}