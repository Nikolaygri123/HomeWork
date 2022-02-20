// Найти сумму чисел одномерного массива, стоящих на нечётной позиции.
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
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

void SumArray(int[] oddsum)
{
    int length = oddsum.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if(i % 2 == 1) sum += oddsum[i];
    }
    Console.WriteLine(sum);
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SumArray(array);