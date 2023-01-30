//12. С клавиатуры вводится целое число из  диапазона  [10, 99].
// Показать наибольшую цифру числа
int N=72;
int d1=N/10;
int d2=N%10;
int max=d1;
if (d2>max) max=d2;
System.Console.WriteLine(max);