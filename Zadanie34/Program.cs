// Написать программу для замены элементов массива на противоположные.
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(-10,10);
        index++;
    }
}

void PrintArray(int[] col, int count)
{
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

void PrintAnotherArray(int[] collec)
{
    int ind = collec.Length;
    int num = 0;
    while(num < ind)
    {
        if (collec[num] > 0) Console.WriteLine(-1*collec[num]);
        else 
        Console.WriteLine(-1*collec[num]);
        num++;
    }
}



int[] array = new int [10];
FillArray(array);
PrintArray(array, array.Length);
Console.WriteLine();
PrintAnotherArray(array);

