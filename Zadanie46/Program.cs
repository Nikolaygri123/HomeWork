// Написать программу масштабирования фигуры
string mass = "";

for (int i = 1; i < 5; i++)
{
    string massiv = "";
    Console.WriteLine($"введите {i} координаты ");
    massiv = Console.ReadLine();
    mass = $"{mass}({massiv})";
}
Console.Write(mass);
Console.WriteLine();



string[] array = mass.Split(' ', '-', ')', '(');
int[] numbers = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{

    Console.Write(array[i] + " ");
}

