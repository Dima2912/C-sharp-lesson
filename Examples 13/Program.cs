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
else
{
while (N > 999)
{
N = N/10; 
}
Console.WriteLine(N%10);
}