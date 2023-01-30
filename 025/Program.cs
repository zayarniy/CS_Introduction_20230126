//25. Задать номер четверти, показать диапазоны для возможных координат
//1. (x>0 and y>0)
//2. (x<0 and y>0)
//3. (x<0 and y<0)
//4. (x>0 and y<0)
int quarter=Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine(quarter);
if (quarter==1) System.Console.WriteLine("x>0 and y>0");
if (quarter==2) System.Console.WriteLine("x<0 and y>0");
if (quarter==3) System.Console.WriteLine("x<0 and y<0");
if (quarter==4) System.Console.WriteLine("x>0 and y<0");