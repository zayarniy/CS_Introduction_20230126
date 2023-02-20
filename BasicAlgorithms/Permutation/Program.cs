//разбор задачи на abc и cab

string s1="ABC1";
string s2="CAB2";
char[] a1=s1.ToCharArray();
char[] a2=s2.ToCharArray();
Array.Sort(a1);
Array.Sort(a2);

string s3=new String(a1);
string s4=new String(a2);
if (s3==s4) System.Console.WriteLine("ДА");
    else System.Console.WriteLine("НЕТ");