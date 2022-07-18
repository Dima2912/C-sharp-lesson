int numbersUser = InputInt("Введите число: ");

int numberOffDigits = NumberDigits(numbersUser);
int summOffNumbersOffDigits = SummOffNumbers(numbersUser, numberOffDigits);
Console. WriteLine($"{numbersUser} -> {summOffNumbersOffDigits}");




int SummOffNumbers(int number, int count)
{
    int summ = 0;

    if(count ==1)
    {
        summ = number;
    }
    else if(count == 2)
    {
        summ = summ + number/10 + number%10;
    }
    else if(count == 3)
    {
        summ = summ + number/100 + number/10%10 + number%10;
    }
    else if(count ==4)
    {
        summ = summ + number/1000 + number/100%10 + number/10%10 + number%10;  
    }
    else Console.WriteLine("Введите число из диапозона 1 до 9999");
    return summ;
}



int NumberDigits (int number)
{
    int count = 0;
    while(number > 0)
    {
        number = number/10;
        count++;
    }
    return count;
}





int InputInt(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}

