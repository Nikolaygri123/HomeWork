

string[] array =
{
    "строки",
    "всякие",
    "и",
    "=)",
    "и",
    "=("
};

for (int i = 0; i < array.Length; i++)
{

    if (array[i].Length <= 3)
    {
        Console.WriteLine(array[i]);

    }
}
