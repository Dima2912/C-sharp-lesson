Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int count = 1;
if(userNumber <= 0)
Console.WriteLine("Введите число > 0");
while(count <= userNumber)
{
    if(count%2 == 0)
    {
        Console.Write(count + " ");
        
    }
    count++;
}
Console.WriteLine();
