// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Проверим,является ли число палиндромом.Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10000;
int b = number / 1000 % 10;
int c = number / 100 % 10;
int d = number / 10 % 10;
int e = number % 10;
if (a == e && b == d)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}