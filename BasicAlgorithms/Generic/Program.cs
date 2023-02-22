//Обобщение (Generic)

List<string> list=new List<string>();
List<int> list2=new List<int>();
List<Random> list3=new List<Random>();

class Example
{

    static void Swap<T>(ref T a,ref T b)//шаблон с параметризированным аргументом
    {
        T t=a;
        a=b;
        b=t;
    }

    // static void Swap(ref int a, ref int b)
    // {
    //     int t=a;
    //     a=b;
    //     b=t;
    // }

    // static void Swap(ref double a, ref double b)//перегрузка по параметрам
    // {
    //     double t=a;
    //     a=b;
    //     b=t;
    // }

    // static void Swap(ref string a, ref string b)//перегрузка по параметрам
    // {
    //     string t=a;
    //     a=b;
    //     b=t;
    // }

    static void Main()
    {
        double x=3,y=5;
        
        System.Console.WriteLine($"x={x} y={y}");
        Swap<double>(ref x,ref y);
        System.Console.WriteLine($"x={x} y={y}");


    }
}

