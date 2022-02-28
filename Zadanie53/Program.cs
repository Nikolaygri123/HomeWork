// В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.
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
Console.WriteLine("укажите число для поиска ");
int finder = Convert.ToInt16(Console.ReadLine());


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (finder == array[i, j])
        {
            Console.WriteLine($" {i}-{j}");
        }
    }
}
