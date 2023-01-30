//Дано число. Проверить есть ли в этом числе цифра 0

int N=12304;
bool flag=false;
while(N!=0)
{
    int digit=N%10;
    if (digit==0)
        flag=true;
    N/=10;//N=N/10
}
if (flag)
    System.Console.WriteLine("В числе есть 0");
else
    System.Console.WriteLine("В числе нет 0");
