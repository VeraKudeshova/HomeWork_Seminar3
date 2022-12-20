// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Enter the first number ");
double a1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number ");
double a2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number ");
double a3 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the fourth number ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the fifth number ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the sixth number ");
double b3 = double.Parse(Console.ReadLine());

double x = Math.Pow(b1-a1,2);
double y = Math.Pow(b2-a2,2);
double z = Math.Pow(b3-a3,2);

double ab = Math.Sqrt(x+y+z);
Console.WriteLine(ab);