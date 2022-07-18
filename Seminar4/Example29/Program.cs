int [] array = new int[8];

FillArray(array);

PrintArray(array);
Console.WriteLine();






void FillArray(int[] arrayUser)
{
    for(int i = 0; i < arrayUser.Length; i++)
    {
        arrayUser[i] = new Random().Next(0, 99);
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