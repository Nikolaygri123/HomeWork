// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int D;
Console.WriteLine("Введите номер дня недели от 1 до 7 ");
D = Convert.ToInt32(Console.ReadLine());
if (D > 5 && D < 8) 
{
    Console.Write("Выходной день - ");
    if (D == 6)
    {
        Console.WriteLine("Суббота ");
    }
    if (D == 7)
    {
        Console.WriteLine("Воскресенье ");
    }
}
else if (D > 0 && D < 5)
{
    Console.WriteLine("Серые будни ");
}
else 
Console.WriteLine("Нет такого дня ");