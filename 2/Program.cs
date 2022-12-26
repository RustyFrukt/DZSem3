/* Задача 2

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

System.Console.Write("Введите коррдинату x точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коррдинату y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коррдинату z точки А: ");
int za = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордианту x точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордианту y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коррдинату z точки А: ");
int zb = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za)),2);
System.Console.WriteLine($"Расстояние между двумя точками: {result}");