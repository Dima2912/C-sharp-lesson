int A = InputInt("Введите число A: ");
int B = InputInt("Введите число B: ");

double rezult = Degry(A, B);
Console.WriteLine($"Число {A}, {B} -> {rezult}");


double Degry(double number1, double number2)
{
    double rez = number1;
    if (number2 == 0)
    {
        rez = 1;
    }
    else if(number2 == 1)
    {
        rez = number1;
    }
    else if (number2 < 0)
    {
        double c = number2*(-1);
        double d = number1;

        for(int i = 1; i < c; i++)
        {
          d = d*number1;
        }
        rez = 1/d;
    }
    else
    {
        for(int i = 1; i < number2; i++)
        {
            rez = rez*number1;
        }
    }
    return rez;
}


int InputInt(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}