
double k1 = IntNumbers("Введите k1: ");
double k2 = IntNumbers("Введите k2: ");
double b1 = IntNumbers("Введите b1: ");
double b2 = IntNumbers("Введите b2: ");
double coordinatX = 0;
double coordinatY = 0;

if (k1 - k2 == 0)
{
    if (b1 - b2 == 0)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        Console.WriteLine("Прямые паралельны");
    }
}
else 
{
    coordinatX = (b2 - b1) / (k1 - k2);
    coordinatY = k1 * coordinatX + b1;
    Console.WriteLine($"Координаты точки пересечения двух прямых ({coordinatX}, {coordinatY})");
}


double IntNumbers (string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}
