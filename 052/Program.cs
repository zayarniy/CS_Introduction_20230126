//52. Написать программу преобразования десятичного числа в двоичное
for(int N1=0;N1<10;N1++)
{
    //     int N2=0;
    // int k=0;
    // while(N!=0)
    // {
    //     N2=N2+N%2*(int)Math.Pow(10,k);
    //     N=N/2;
    //     k++;
    // }
    System.Console.WriteLine($"{N1} {DecToBin(N1),10}");
}

int DecToBin(int N)
{
    int N2=0;
    int k=0;
    while(N!=0)
    {
        N2=N2+N%2*(int)Math.Pow(10,k);
        N=N/2;
        k++;
    }
    return N2;    
}