// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки 1");
Console.Write("X1 ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1 ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2");
Console.Write("X2 ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2 ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());


double distance = Distance(x1Coordinate, y1Coordinate, x2Coordinate, y2Coordinate, z1Coordinate, z2Coordinate);
double distanceRound = Math.Round(distance, 3, MidpointRounding.ToZero);
Console.WriteLine(distanceRound);

double Distance(int x1, int y1, int x2, int y2, int z1, int z2)
{
   return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+Math.Pow(z1 - z2, 2));
}


