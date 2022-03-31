int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(1,10);
   Console.WriteLine(array[i]);
}  

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0 )
    {
        sum += array [i];
    }
}
Console.WriteLine();
Console.WriteLine(sum);