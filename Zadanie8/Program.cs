// Показать чётные числа от 1 до N.
int a;
int i = 1;
Console.WriteLine("Введите число ");
a = Convert.ToInt32(Console.ReadLine());
while  (i < a)
{
    Console.WriteLine(i+1);
    i+= 2;
}
