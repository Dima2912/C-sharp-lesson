int userNumbers = InputInt("Введите число: ");

for(int count = 1; count <= userNumbers; count++)
{
    int rez = count*count*count;
    if(count <= userNumbers - 1)
    {
      Console.Write($"{rez}, ");  
    }

    else
    {
      Console.Write($"{rez}.");  
    }
}

int InputInt(string output)   // Метод ввода числа с консоли
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}