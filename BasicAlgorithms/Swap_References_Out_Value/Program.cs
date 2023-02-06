using System;

// void Swap(int x, int y)//передача по значению(value)
// {
//     int t=x;
//     x=y;
//     y=t;
// }

void Swap(ref int x, ref int y)//передача по ссылке(references)
{
    int t=x;
    x=y;
    y=t;
}

void Calculator(int a,int b,out int sum, out int sub)
{
    sum=a+b;
    sub=a-b;
}

// int u,r=0,o=0;
// u=r+o;

int a=4;
int b=5;
int s,sb;
Calculator(a,b,out s,out sb);



Console.WriteLine($"a={a} b={b}");
//Классический  (стандартный) обмен
Swap(ref a,ref b);
Console.WriteLine($"a={a} b={b}");




















// a=a+b;
// b=a-b;
// a=a-b;