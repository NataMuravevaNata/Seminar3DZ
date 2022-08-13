// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты точки A");
Console.WriteLine("Введите x1");
int x1=int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите y1");
int y1=int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите z1");
int z1=int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты точки B");
Console.WriteLine("Введите x2");
int x2=int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите y2");
int y2=int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите z2");
int z2=int.Parse(Console.ReadLine() ?? "0");
Double result;
result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние между точками равно: {result} ");