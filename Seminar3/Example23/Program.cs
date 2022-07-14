int userNumbers = InputInt("Введите число: ");

for(int count = 1; count <= userNumbers; count++)
{
    int rez = count*count*count;
    Console.WriteLine(rez);
}

int InputInt(string output)   // Метод ввода числа с консоли
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}