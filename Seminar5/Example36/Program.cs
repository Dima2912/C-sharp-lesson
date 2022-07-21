int sizeArray = InputSizeArray("Введите размер массива: ");

int [] array = new int[sizeArray];

FillArray(array);

int summ = 0;
for(int i=0; i < array.Length; i++)
{
    if(array[i]%2 == 1)
    {
        summ = summ +array[i];
    }
}

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {summ}");

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
        arrayUser[i] = new Random().Next(0, 100);
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