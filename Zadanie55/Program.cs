// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int[,] array = new int[4, 5];
void fillArray(int[,] filled)
{
    for (byte i = 0; i < filled.GetLength(0); i++)
    {
        for (byte j = 0; j < filled.GetLength(1); j++)
        {
            filled[i, j] = new Random().Next(1, 10);
        }
    }
}
void printArray(int[,] printed)
{
    for (byte i = 0; i < printed.GetLength(0); i++)
    {
        for (byte j = 0; j < printed.GetLength(1); j++)
        {
            Console.Write(printed[i, j] + " ");
        }
        Console.WriteLine();
    }
}
fillArray(array);
printArray(array);

void findsred(int[,] finder)
{
    for (int i = 0; i < finder.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < finder.GetLength(0); j++)
        {
            sum = sum + finder[j, i];

        }
        Console.WriteLine(sum / 4);
    }
}
findsred(array);
