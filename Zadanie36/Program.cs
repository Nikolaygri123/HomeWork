// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(100, 999);
        index++;
    }
}

void PrintArray(int[] col)
{
    int lenght = col.Length;
    int position = 0;
    while (position < lenght)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

void ShowArray(int[] collec)
{
    int ind = collec.Length;
    int num = 0;
    int even =0;
    int odd =0;
    while(num < ind)
    {
        if (collec[num] % 2 == 0) 
        {
            even++;
        }
        else 
        odd++;
        num++;
    }
    Console.WriteLine("Четных чисел - " + even);
    Console.WriteLine("Нечетных чискл - " + odd);
}

int[] array = new int [10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ShowArray(array);