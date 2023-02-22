
//Написать метод для арифметических операций

//без делегатов
//Перечисления

class Program
{
enum Operation
{
    Summ=0, Multi=1, Divide=2, Sub=3
}

static int Calc(int a,int b,Operation oper)
{
    if (oper==Operation.Summ) return a+b;
    if (oper==Operation.Multi) return a*b;
    if (oper==Operation.Divide) return a/b;
    if (oper==Operation.Sub) return a-b;
    return 0;
}


static void Main()
{
    Console.ForegroundColor=ConsoleColor.DarkBlue;
    System.Console.WriteLine(Calc(2,2,Operation.Multi));
    ConsoleKeyInfo keyInfo=Console.ReadKey();
    if (keyInfo.Key==ConsoleKey.Escape) System.Console.WriteLine("Escape");
}
}

