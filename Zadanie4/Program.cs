// Найти максимальное из трёх чисел
int a, b, c;
Console.WriteLine("Введите три числа ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if(b > max) max = b;
if(c > max) max = c;
Console.WriteLine("Максимальное число " + max);