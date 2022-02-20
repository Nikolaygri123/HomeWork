//  В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.
void FillArray(double[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(-99, 99) + new Random().NextDouble();
    }
}

void PrintArray(double[] col)
{
    int lenght = col.Length;
    int position = 0;
    while (position < lenght)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

void MaxAndMinArray(double[] find)
{
    double max = find[0];
    double min = find[0];
    for (int i = 0; i < find.Length; i++)
    {
        if(find[i] >= max) max = find[i];
        else if(find[i] <= min) min = find[i];
    }
    Console.WriteLine("Максимальное число массива  " + max);
    Console.WriteLine("Минимальное число массива  " + min);
    Console.WriteLine("Разница между максимальным и минимальным числом  " + (max - min));
}

double[] array = new double[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
MaxAndMinArray(array);