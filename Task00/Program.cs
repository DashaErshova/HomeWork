// Напишите программу, которая н вход принимает чсло и выдаёт его квадрат (число умноженное на себя)
// например ж 4->16, -3 -> 9? -7 -> 49

Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");

