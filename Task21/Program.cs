// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X точки A: ");
int AX = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
int AY = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки A: ");
int AZ = int.Parse(Console.ReadLine());

Console.Write("Введите координату X точки B: ");
int BX = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int BY = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int BZ = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(BX - AX, 2) + Math.Pow(BY - AY, 2) + Math.Pow(BZ - AZ, 2));
Console.WriteLine($"Расстояние между точками A и B равно {distance}");