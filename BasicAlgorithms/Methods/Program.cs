//Напишите подпрограмму нахождения расстояния между двумя точками

//Сигнатура метода ()
//double (double, double, double, double)

//тип Название(аргументы)

//метод, функция (C)
double Distance(double x1,double y1, double x2,double y2)
{
    //double(double)
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));
}

//процедуры - C# -нет
//void()
void Pause()
{
    Console.ReadKey();
}

double x1=0,y1=0,x2=2,y2=2;

//double distance=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));
double distance=Distance(0,0,2,2);
System.Console.WriteLine(distance);
System.Console.WriteLine(Distance(0,0,2,2));
Pause();