//Подсчитать среднюю температуру за неделю
// double t1,t2,t3,t4,t5,t6,t7;
// t1=Convert.ToDouble(Console.ReadLine());
// t2=Convert.ToDouble(Console.ReadLine());
// t3=Convert.ToDouble(Console.ReadLine());
// t4=Convert.ToDouble(Console.ReadLine());
// t5=Convert.ToDouble(Console.ReadLine());
// t6=Convert.ToDouble(Console.ReadLine());
// t7=Convert.ToDouble(Console.ReadLine());
// double sr=(t1+t2+t3+t4+t5+t6+t7)/7;
// System.Console.WriteLine(sr);
int b1=4;
int b2=4;
System.Console.WriteLine(b1==b2);
int[] a1=new int[3];
int[] a2=new int[3];
a1[0]=1;
a1[1]=1;
a1[2]=1;
a2[0]=1;
a2[1]=1;
a2[2]=1;
a1=a2;
System.Console.WriteLine(a1==a2);



















int y=0;
System.Console.WriteLine(y);
//инициализация переменных
double[] temps;
temps=new double[7];
//ввод данных
for(int i=0;i<temps.Length;i++)
   temps[i]=Convert.ToDouble(Console.ReadLine());
//решение задачи
//находим сумму массива
double s=0;
for(int i=0;i<temps.Length;i++)
    s=s+temps[i];
//вывод результата
System.Console.WriteLine(s/temps.Length);