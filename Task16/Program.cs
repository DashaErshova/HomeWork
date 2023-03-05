// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool isSquare = IsSquare(number1, number2);
Console.WriteLine(isSquare ? "Да" : "Нет");

bool  IsSquare(int number1, int number2)
{
    return (number1 == number2 * number2) || (number2 == number1 * number1);
}
