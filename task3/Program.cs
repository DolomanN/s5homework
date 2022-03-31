double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100,1000);
Console.WriteLine(array[i]);
}

double max = array [0];
double min = array [0];

for (int i = 0; i < array.Length; i++)
{
if (array[i] > max)
{
max = array[i];
}
else if (array[i] < min)
{
min = array[i];
}

}

double result = max - min;
Console.WriteLine();
Console.WriteLine($"максмальное значение массива {max}");
Console.WriteLine($"минимальное значение массива {min}");
Console.WriteLine($"разница {result}");
