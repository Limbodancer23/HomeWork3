// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
System.Console.WriteLine("Enter x(a) ");
double numXa = double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter x(b) ");
double numXb = double.Parse(Console.ReadLine());

System.Console.WriteLine("Enter y(a) ");
double numYa = double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter y(b) ");
double numYb = double.Parse(Console.ReadLine());

System.Console.WriteLine("Enter z(a) ");
double numZa = double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter z(b) ");
double numZb = double.Parse(Console.ReadLine());

double partX = (numXb - numXa); 
double partY = (numYb - numYa);
double partZ = (numZb - numZa);
double part2 = Math.Sqrt(Math.Pow(partX, 2)+Math.Pow(partY, 2)+Math.Pow(partZ, 2));
Console.WriteLine(Math.Round(part2, 2));