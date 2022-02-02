// Выяснить является ли число чётным
int a;
Console.WriteLine("Введите число ");
a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine(a + " - Четное число");
}
else 
Console.WriteLine(a + " - нечетное число");