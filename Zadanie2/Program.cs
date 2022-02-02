// Даны два числа. Показать большее и меньшее число
int a, b;
Console.WriteLine("Введите два числа ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Наибольшее число " + a);
    Console.WriteLine("Наименьшее число " + b);
}
else if (a < b)
{
    Console.WriteLine("Наименьшее число " + a);
    Console.WriteLine("Наибольшее число " + b);
}
else if (a == b)
{
     Console.WriteLine("Числа равны ");
}