// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


System.Console.WriteLine("Input x1");
double x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input y1");
double y1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input x2");
double x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input y2");
double y2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input x3");
double x3 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input y3");
double y3 = Convert.ToInt32(Console.ReadLine());

double x4 = Math.Pow(x1 - x2 -x3, 2);
double y4 = Math.Pow(y1 - y2 - x3, 2);

System.Console.WriteLine($"The result is {Math.Sqrt(x4 + y4)}");