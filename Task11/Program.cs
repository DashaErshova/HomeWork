// // Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифруэтого числа.
//  456  - 46
//  782 - 72
//  918 - 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число {number}");
int firstDigit = number / 100;
int lastDigit = number % 10;
int result = firstDigit * 10 + lastDigit;
Console.WriteLine($"двухзначное число {result}");
