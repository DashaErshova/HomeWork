// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> {ToBinary(number)}.");


int ToBinary(int numberValue)
{
int binaryNumber = 0, buffer = numberValue, dec = 1;
while (buffer > 0)
{
binaryNumber = binaryNumber + buffer % 2 * dec;
dec *= 10;
buffer /= 2;
}
return binaryNumber;
}