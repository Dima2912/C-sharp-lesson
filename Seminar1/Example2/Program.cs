Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
int maxNumber = userNumber1;
if(maxNumber < userNumber2)
    maxNumber = userNumber2;
Console.WriteLine("Максимальное число = "+ maxNumber);





