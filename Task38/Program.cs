// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным
//  и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = CreateArrayRndDouble(size, 0, 100);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
    {
        max = numbers[z];
    }
    if (numbers[z] < min)
    {
        min = numbers[z];
    }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rand.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num,1);
    }
    return arr;
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}