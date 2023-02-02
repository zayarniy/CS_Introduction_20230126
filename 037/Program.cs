//37.  Компьютер придумывет число и определяет заканчивается ли на четную цифру куб этого число.
bool Test(int n)
{
    return n%2==0;
    // if (n%2==0)
    //   return true;
    // else
    //   return false;
}


Random random;//описали переменную типа Random
random=new Random();//создали объект
int c;//описываем
c=3;
for(int i=0;i<10;i++)
{
    int a=random.Next(1,100);
    int b=(int)Math.Pow(a,3);
    if (Test(a))
      System.Console.WriteLine($"{a}, {b}");
}










