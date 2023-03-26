// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = CreateRandomMatrix(2, 2, 1, 10);
int[,] matrix2 = CreateRandomMatrix(2, 2, 1, 10);

// Вывод исходных матриц в консоль
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);
Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);

// Проверка возможности умножения матриц
if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Невозможно выполнить умножение матриц: количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    return;
}

// Создание результирующей матрицы произведения
int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

// Вычисление произведения матриц
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            sum += matrix1[i, k] * matrix2[k, j];
        }
        product[i, j] = sum;
    }
}

// Вывод результирующей матрицы произведения в консоль
Console.WriteLine("Матрица произведения:");
PrintMatrix(product);


    // Метод для создания матрицы со случайными значениями
   int[,] CreateRandomMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }

    return matrix;
}

// Метод для вывода матрицы в консоль
 void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}