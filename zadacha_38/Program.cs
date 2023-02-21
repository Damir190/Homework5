// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

double[] array = new double[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = rand.Next(-10, 10) + rand.NextDouble();

Console.WriteLine(String.Join(" ", array));

double max = 0;
double min = 0;
double min1 = 0;

foreach (double i in array)
{
    if (min > i) min = i;
    if (max < i) max = i;
}

if (min < 0) min1 = min * -1;

Console.WriteLine($"Максимальный элемент: {max}, минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным: {max - min1}");