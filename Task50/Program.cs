// Задача 50. Напишите программу, которая на вход принимает
//  позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание,
//   что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] array = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

Console.Write("Введите индекс строки:");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите индекс столбца:");
int col = int.Parse(Console.ReadLine());

int value = GetValue(array, row, col);

if (value == -1)
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    Console.WriteLine($"Значение элемента ({row}, {col}): {value}");
}


int GetValue(int[,] array, int row, int col)
{
int numRows = array.GetLength(0);
int numCols = array.GetLength(1);

 if (row < 0 || row >= numRows || col < 0 || col >= numCols)
 {
 return -1;
}

return array[row, col];
}