//Дано число. Найти максимальную и минимальную цифру числа

int N=1234;
int min,max;
min=10;
max=-1;
while(N!=0)
{
    int digit=N%10;
    if (digit>max) max=digit;
    if (digit<min) min=digit;
    N=N/10;
}
System.Console.WriteLine($"min={min} max={max}");//Строка интерполяции
//System.Console.WriteLine("min="+min+" max="+max);
