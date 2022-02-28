// Задать двумерный массив следующим правилом: Aₘₙ = m+n.
int[,] massiv = new int[5, 5];
void fillArray(int[,] filled)
{
    for (int i = 0; i < filled.GetLength(0); i++)
    {
        for (int j = 0; j < filled.GetLength(1); j++)
        {
            filled[i, j] = i + j;
        }
    }
}
void printArray(int[,] printed)
{
    for (int i = 0; i < printed.GetLength(0); i++)
    {
        for (int j = 0; j < printed.GetLength(1); j++)
        {
            Console.Write($"{printed[i, j]} ");
        }
        Console.WriteLine();
    }
}
fillArray(massiv);
printArray(massiv);
