Console.Write("Введите параметр а: ");
double a = double.Parse(Console.ReadLine());
double z1 = 1 - 1 / 4 * Math.Pow(Math.Sin(2 * a), 2) + Math.Cos(2 * a); // 5 example
double z2 = Math.Pow(Math.Cos(a), 2) + Math.Pow(Math.Cos(a), 4);
Console.WriteLine($"z1: {z1:0.000}\n z2: {z2:0.000}");
Console.Write("Введите параметр b: ");
double b = double.Parse(Console.ReadLine());
double z3 = Math.Cos(b) + Math.Cos(2 * b) + Math.Cos(6 * b) + Math.Cos(7 * b); // 6 example 
double z4 = 4 * Math.Cos(b / 2) * Math.Cos(5 / 2 * b) * Math.Cos(4 * b);
Console.WriteLine($"z2: {z2:0.000}\n z4: {z4:0.000}");
