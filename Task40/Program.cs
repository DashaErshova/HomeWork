// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.



Console.WriteLine("Введите первую сторону ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckTriangle(a, b, c)? "Да" : "Нет");

bool CheckTriangle(int a, int b, int c)
{
if (a < b + c)
{
if (b < a + c)
{
if (c < a + b) return true;
else return false;
}
else return false;
}
else return false;
}
