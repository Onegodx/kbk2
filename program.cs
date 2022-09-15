// Миньков Владимир вариант 15
Console.WriteLine("Введите y:");
int y = int.Parse(Console.ReadLine());

double E = Math.Sin(Math.Pow(y, 2)) - 2.8 * y + Math.Sqrt(Math.Abs(y));
Console.WriteLine($"{E:F2}");
