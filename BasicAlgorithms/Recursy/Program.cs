//Вывести на экран числа от 1 до N без использования цикла. GOTO запрещен
int N=20;

int i=0;

//System.Console.WriteLine(i++);//постинкримент
// System.Console.WriteLine(++i);//прединкримент
// System.Console.WriteLine(i);

// while(i<N) 
// {
//     //i++;//инкремент
//     System.Console.Write($"{i++,4}");
// }

//!!!!!!!!!!!ЗАПРЕЩЕНО!!!!!!!
// metka:
//   System.Console.Write($"{i++,4}");
// if (i<N) goto metka;//оператор безусловного перехода

//рекурсивный метод
void Loop(int i, int N)
{
    System.Console.Write($"{i,4}");
    if (i<N) Loop(i+1,N);//рекурсия
}


int F(int N)
{
    if (N>0) return F(N-1)*N;
    else return 1;
}

int Fib(int N)
{
    if (N==0) return 0;
        else
            if (N==1) return 1;
                else
                    return Fib(N-1)+Fib(N-2);
}

double Power(int a,int b)
{
    if (b==0) return 1;
    else 
      if (b>0)
        return Power(a,b-1)*a;
      else
        return Power(a,b+1)*1/a;

}

//Loop(1,20);
//System.Console.WriteLine(F(5));
for(i=-10;i!=0;i++)
    //System.Console.WriteLine(Fib(i));
    System.Console.WriteLine(Power(2,i));