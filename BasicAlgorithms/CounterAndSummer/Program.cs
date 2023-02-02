// Подсчитать кол-во цифр и сумму цифр
int N=1234;//Number
N=Convert.ToInt32(Console.ReadLine());
int counter=0;//счетчик
int sum=0;//сумматор
while(N!=0)//пока N не равно 0
{
    //counter=counter+1;
    counter++;
    int d=N%10;
    //sum=sum+d;
    sum+=d;
    //N=N/10;
    N/=10;
}
System.Console.WriteLine(counter);
System.Console.WriteLine(sum);


//123456/System.Math.Pow(10,4)%10