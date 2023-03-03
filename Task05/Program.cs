// // Напишите программу, которая на вход принимает число (Т), 
// а на выходе показывает все целые числа от -N до N
// 4-> "-4,-3,-2,0,1,2,3,4"
// 2-> " -2,-1,0,1,2"


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >0){
for ( int i =-number; i <=number; i++)
{
Console.Write ( i + " ");
}
}
else
{
    Console.Write ("Должно быть положительное число ");
}