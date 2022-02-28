// Показать двумерный массив размером m×n, заполненный вещественными числами.
double[,] array = new double[4, 5];
void fillArray(double[,] filled)
{
    for (byte i = 0; i < filled.GetLength(0); i++)
    {
        for (byte j = 0; j < filled.GetLength(1); j++)
        {
            filled[i, j] = new Random().NextDouble() * 5;
        }
    }
}
void printArray(double[,] printed)
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
