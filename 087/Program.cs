//87. Удалить средний символ при нечетное длине 
//строки и две средние буквы при четной длине строки

//ABCD=AD
//ABC=AC

string s="ABCDE";
if (s.Length%2==0)
  s=s.Remove(s.Length/2-1,2);
  else
    s=s.Remove(s.Length/2,1);
System.Console.WriteLine(s);    