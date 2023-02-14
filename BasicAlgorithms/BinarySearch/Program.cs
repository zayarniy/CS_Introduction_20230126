// Бинарный поиск
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

int BinSearch(int[] arr,int find)
{
    int i;
    int left=0;
    int right=arr.Length-1;
    i=left+(right-left)/2;
    while(arr[i]!=find && left<right)
    {
        if (find>arr[i])
        {
                left=i+1;
        }
        else
        {
            right=i;
        }
        i=left+(right-left)/2;
    }
    if (arr[i]!=find) return -1;
    else return i;
}

int f=20;
int[] a=RandomIntArray(6,0,100);
PrintArray(a);
Array.Sort(a);//сортировка массива
System.Console.WriteLine();
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine(BinSearch(a,f));

