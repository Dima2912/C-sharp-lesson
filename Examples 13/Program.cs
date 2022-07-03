Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 9 & N <= 99)
{
   Console.WriteLine("Третьей цифры нет"); 
}
else if (N > 99 & N <= 999)
{
    int a = N%10;
    Console.WriteLine(a); 
}
else if (N > 999 & N <= 9999)
{
    int b = N%100; int c = b/10;
    Console.WriteLine(c);
}