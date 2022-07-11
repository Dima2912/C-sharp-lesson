Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int userNumber3 = Convert.ToInt32(Console.ReadLine());
int maxNumber = userNumber1;
if(userNumber2 > maxNumber)
maxNumber = userNumber2;
else if(userNumber3 > maxNumber)
maxNumber = userNumber3;
Console.WriteLine( $"Максимальное число = {maxNumber}");