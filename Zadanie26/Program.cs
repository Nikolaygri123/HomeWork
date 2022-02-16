// Возведите число А в натуральную степень B, используя цикл.
Console.WriteLine("введите число ");
double b =Convert.ToDouble(Console.ReadLine());

for (int i = 2; i <= b; i++)
{
    for (int j = 2; j <=b; j++)
    {
    Console.WriteLine(Math.Pow(i,j));
    }
}