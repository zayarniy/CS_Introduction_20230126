//Двухмерный массив
int[,] Random2DArray(int N, int M,int min, int max)                      
{
    int[,] a=new int[N,M];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
}

double[,] Random2DArrayDouble(int N, int M,int min, int max)                      
{
    double[,] a=new double[N,M];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.NextDouble();
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],6:F2}");
    System.Console.WriteLine();
    }
}

bool FindElementIn2DArray(int[,] a,int find,out int row,out int column)
{
    row=-1;
    column=-1;
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            if (a[i,j]==find) 
            {
                row=i;
                column=j;
                return true;
            }
    return false;
}

//66. Написать подпрограмму, которая в квадратной матрице чисел находит сумму элементов главной диагонали
int SumMainDiagonal(int[,] a)
{
    int s=0;
    for(int i=0;i<a.GetLength(0);i++) 
    {
       s=s+a[i,i];
    }
    return s;
}

int[,] a=Random2DArray(4,4,0,10);
Print2DArray(a);
int r,c;
if (FindElementIn2DArray(a,10,out r,out c))
  System.Console.WriteLine($"row={r} column={c}");
else
  System.Console.WriteLine("Element not found");

System.Console.WriteLine(SumMainDiagonal(a));

















// Трехмерный массив

// int[,,] a=new int[4,3,3];
// for(int k=0;k<a.GetLength(2);k++)
//     for(int i=0;i<a.GetLength(0);i++)
//         for(int j=0;j<a.GetLength(1);j++)
//                     a[i,j,k]=k*100+i*10+j;

// for(int k=0;k<a.GetLength(2);k++)
// {
//     System.Console.WriteLine(k);
//     for(int i=0;i<a.GetLength(0);i++)
//     {
//     for(int j=0;j<a.GetLength(1);j++)
//         System.Console.Write($"{a[i,j,k],5}");
//     System.Console.WriteLine();
//     }

// }