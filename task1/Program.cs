int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(100,1000);
   Console.WriteLine(array[i]);
}  
Console.WriteLine();

int Even =0;
int Odd = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0 )
    {
        Even  += 1;
    }
    else 
    {
        Odd += 1;
    }
}
Console.WriteLine($"Четные =  {Even}");
Console.WriteLine($"Нечетные =  {Odd}");
