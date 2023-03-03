// // Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает  последнюю цифру этого числа.
//  456-> 6
//  782-> 2
//  918-> 8

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number > 99 && number < 1000)
{
    int result = number % 10;
    Console.Write(result);
}
else
{
    Console.WriteLine("Необходимо ввести трехзначное число");
}