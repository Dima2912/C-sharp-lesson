int sizeArray = InputSizeArray("Введите размер массива: ");

int [] array = new int[sizeArray];

FillArray(array);

int countPositivNumbers = 0;
for(int i=0; i < array.Length; i++)
{
    if(array[i]%2 == 0)
    {
        countPositivNumbers = countPositivNumbers +1;
    }
}

Console.WriteLine($"Количество четных чисел в массиве равно: {countPositivNumbers}");

PrintArray(array);
Console.WriteLine();



int InputSizeArray(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}


void FillArray(int[] arrayUser)
{
    for(int i = 0; i < arrayUser.Length; i++)
    {
        arrayUser[i] = new Random().Next(100, 1000);
    }

}


void PrintArray(int [] arrayUser)
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