Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if(userNumber%2 == 0)
Console.WriteLine($"{userNumber} - четное число");
else 
Console.WriteLine($"{userNumber} - не четное число");
