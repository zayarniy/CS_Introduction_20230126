// Делегаты
//Написать метод для арифметических операций

//без делегатов
//Перечисления

class Program
{
  delegate int Operation(int a, int b); //int(int,int)
  delegate O SuperOperation<in T, out O>(T a, T b);
static int Calc(int a,int b,Operation oper)
{
    return oper(a,b);
}

static int Sum(int a, int b)
{
    return a+b;
}

static double Divide(int a, int b)//double(int,int)
{
    return a/b;
}

static int Multi(int a, int b)
{
    return a*b;
}

static int Sum2Digit(int a)
{
     return a/10+a%10;
}

static void Main()
{

    int[] a={12,34,42,32};
    //double[] b=Array.ConvertAll<int, double>(a,Convert.ToDouble);
    //int[] c=Array.ConvertAll<int,int>(a, Sum2Digit);
    // int[] c=Array.ConvertAll<int,int>(a, 
    // delegate (int a)//анонимный делегат
    // {
    //     return a/10+a%10;
    // }
    // );
    // int[] c=Array.ConvertAll<int,int>(a, 
    // (a)=> //лямбда-выражение
    // {



    //     return a/10+a%10;
    // }
    // );
    int[] c=Array.ConvertAll<int,int>(a, 
    (n)=> n/10+n%10 //однострочное лямбда-выражение
    );

    foreach(int el in c)
      System.Console.Write($"{el,4}");
    //System.Console.WriteLine(Calc(2,3,Multi));
    
}
}

