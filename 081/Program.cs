// 81. Вывести на экран символы от A до Z как показано ниже: 
// A 
// BB 
// CCC 

for(char c='A';c<='Z';c++)
{
   for(int i=0;i<c-'A'+1;i++)
    System.Console.Write(c);
  System.Console.WriteLine();
}