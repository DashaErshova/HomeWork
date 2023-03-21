// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



Console.WriteLine("До какого числа вывести ряд Фибоначчи?");
int number = Convert.ToInt32(Console.ReadLine());

int [] FibonacciArray(int num)
{
int[] array = new int[num];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < num; i++)
{
array[i] = array[i - 1] + array[i - 2];
}
return array;
}
int[] newArray = FibonacciArray(number);

for (int i = 0; i < number; i++)
{
Console.Write($"{newArray [i]} ");
}