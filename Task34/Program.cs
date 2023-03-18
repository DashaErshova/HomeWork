// // Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
//Напишите программу, которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int size = 5; // Указать размер массива 
int[] array = new int[size];
int count = 0;
FillArray(array);
WriteArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Колличество четных чисел: {count}");

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(10, 1000);
    }
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}