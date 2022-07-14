int x1 = InputInt("Введите X1: ");
int y1 = InputInt("Введите Y1: ");
int z1 = InputInt("Введите Z1: ");

int x2 = InputInt("Введите X2: ");
int y2 = InputInt("Введите Y2: ");
int z2 = InputInt("Введите Z2: ");

int distanceX = x1 - x2;
int distanceY = y1 - y2;
int distanceZ = z1 - z2;

double distance = Math.Sqrt(Quadro(distanceX) + Quadro(distanceY) + Quadro(distanceZ));
Console.WriteLine($"Расстояние между двумя точками = {distance}");

int InputInt(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}

int Quadro(int number)
{
    int quadro;
    return quadro = number * number;
}
