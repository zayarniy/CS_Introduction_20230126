// Создать частотный словарь

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
int[] a=RandomIntArray(10, 1,5);
PrintArray(a);
System.Console.WriteLine();
Dictionary<int, int> dic=new Dictionary<int, int>();
foreach(int el in a)
  if (dic.ContainsKey(el))
     dic[el]++;
   else
     dic.Add(el,1);
foreach(var el in dic)
  System.Console.WriteLine($"{el.Key}:{el.Value}");