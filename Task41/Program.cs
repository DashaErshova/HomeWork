// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Введите числа через запятую: ");
int[] numbers = ConvertToInt32(Console.ReadLine());

Console.WriteLine("Введенные числа:");
PrintArray(numbers);

int counter = CountPositiveNumbers(numbers);

Console.WriteLine($"Всего {counter} чисел(а) больше 0");


int[] ConvertToInt32(string input)
{
    string[] stringNumbers = input.Split(',');
    int[] numbers = new int[stringNumbers.Length];

    for (int i = 0; i < stringNumbers.Length; i++)
    {
        numbers[i] = int.Parse(stringNumbers[i].Trim());
    }

    return numbers;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}


    int CountPositiveNumbers(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                count++;
            }
        }
        return count;
    }
