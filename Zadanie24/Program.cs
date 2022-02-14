// Найти кубы чисел от 1 до N
int a = 1;
Console.WriteLine("Введите конечное число ");
double b = Convert.ToDouble(Console.ReadLine());
              while (a <= b)
             {
                 Console.WriteLine("Куб числа " + a);
                 Console.WriteLine(("Число " + a * a * a));
                 a++;
             }