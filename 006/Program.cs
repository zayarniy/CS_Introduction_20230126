//6. Написать программу вычисления значения функции y = sin(a). (Класс Math). 

double a=Convert.ToDouble(Console.ReadLine());
double y=Math.Sin(a);
System.Console.WriteLine($"sin({a})={y}");