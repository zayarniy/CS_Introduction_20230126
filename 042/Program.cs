//42. Задать массив из 12 элементов, заполненных числами из [-9, 9].
// Найти сумму положительных/отрицательных элементов массива

int[] a=new int[3];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(-9,10);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();
int sp=0;
for(int i=0;i<a.Length;i++)
    if (a[i]>0)
        sp=sp+a[i];

int sn=0;
for(int i=0;i<a.Length;i++)
    if (a[i]<0)
        sn=sn+a[i];
System.Console.WriteLine($"Sum of positive numbers:{sp}");        
System.Console.WriteLine($"Sum of negative numbers:{sn}");        
