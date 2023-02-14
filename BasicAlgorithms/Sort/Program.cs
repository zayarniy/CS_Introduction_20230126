// Сортировки
int[] RandomIntArray(int N, int min, int max)
{
    int[] arr=new int[N];
    Random random=new Random();
    for(int i=0;i<arr.Length;i++)
        arr[i]=random.Next(min,max+1);
    return arr;
}

void PrintArray(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
        System.Console.Write($"{arr[i],5}");
}

int BubbleSort(int[] a)
{
    int k=0;
    for(int j=0;j<a.Length;j++)
        for(int i=0;i<a.Length-1-j;i++)
        {            
            if (a[i]>a[i+1])
            {
                int t=a[i];
                a[i]=a[i+1];
                a[i+1]=t;               
            }
             k++;
        }
    return k;
}

int SelectSort(int[] a)
{
    int k=0;
    for(int j=0;j<a.Length;j++)
    {
        int iM=j;
        for(int i=j+1;i<a.Length;i++)        
        {
            if (a[i]<a[iM])
            {
              iM=i;             
            }
            k++;
        }    
        int t=a[j];
        a[j]=a[iM];
        a[iM]=t;
    }
    return k;

}


int[] a=RandomIntArray(20,0,100);
int[] b=new int[a.Length];
Array.Copy(a,b,a.Length);
PrintArray(a);
//Array.Sort(a);//сортировка массива
int k1=SelectSort(a);
int k2=BubbleSort(b);
System.Console.WriteLine();
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine($"Select sort:{k1}");
System.Console.WriteLine($"Bubble sort:{k2}");

