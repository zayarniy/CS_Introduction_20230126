//82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки
string s="It's a simple task Yes!";

// int i=0;
// while (i<s.Length && s[i]!='.') i++;
// if (i==s.Length) 
//     System.Console.WriteLine(-1);
// else
//     System.Console.WriteLine(i);

System.Console.WriteLine(s.IndexOf('.'));
//System.Console.WriteLine(s.Split('.')[0].Length);
