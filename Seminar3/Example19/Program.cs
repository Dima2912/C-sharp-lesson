int number = InputInt("Введите пятизначное число: ");

int firstNumberDigit = number/10000;
int secondNumberDigit = number%10000/1000;
int thirdNumberDigit = number%1000/100;
int fourthNumberDigit = number%100/10;
int fifthNumberDigit = number%10;
     
if (number >= 10000 && number <= 99999)
{
    if(firstNumberDigit == fifthNumberDigit && secondNumberDigit == fourthNumberDigit)
    {
       Console.WriteLine("Число " + number + " является полиндромом"); 
    }
   else 
   {
    Console.WriteLine("Число " + number + " не является полиндромом"); 
   }

}
else
{
    Console.WriteLine("Число не является пятизначным");
}

int InputInt(string output)   // Метод ввода числа с консоли
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}