// Даны два числа. Показать большее и меньшее число
int a, b;
Console.WriteLine("Введите два числа ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("Числа равны");
}
else if (a > b)
{
    Console.WriteLine("Наибольшее число " + a);
}
else
    Console.WriteLine("Наименьшее число " + a);