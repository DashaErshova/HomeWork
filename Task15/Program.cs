// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Номер дня недели ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("Да, это выходной день.");
}
else if (number <= 5)
{
    Console.WriteLine("Нет, это не выходной день");

}
else 
{
    Console.WriteLine("Такого дня недели не существует");
}