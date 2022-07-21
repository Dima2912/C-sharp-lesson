int sizeArray = InputSizeArray("Введите размер массива: ");

double [] array = new double[sizeArray];

FillArray(array);

double d = DifferenceBetweenMaximumAndMinimum(array);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {d}");

PrintArray(array);
Console.WriteLine();


double DifferenceBetweenMaximumAndMinimum(double []arrayUser)
{
    double difference = 0;
    double max = array[0]; 
    double min = array[0];

    for(int i=1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
        max = array[i];
        }
        else if(array[i] < min)
        {
        min = array[i];
        }
    }

    return difference = max - min;
}


int InputSizeArray(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}


void FillArray(double[] arrayUser)
{
    double a = 0; 
    double b = 0;
    for(int i = 0; i < arrayUser.Length; i++)
    {
        a = new Random().Next(0, 100);
        b = new Random().Next(0, 100);
        arrayUser[i] = Convert.ToDouble($"{a},{b}");
    }

}


void PrintArray(double [] arrayUser)
{
    for( int i = 0; i < arrayUser.Length; i++)
    {
        if(i ==0)
        {
          Console.Write($"[{arrayUser[i]}, ");  
        }
        else if(i == arrayUser.Length-1)
        {
          Console.Write($"{arrayUser[i]}]");  
        }
        else
        {
            Console.Write($"{arrayUser[i]}, ");
        }
    }
}