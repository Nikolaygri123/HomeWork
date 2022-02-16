// Покажите кубы чисел, заканчивающихся на чётную цифру.
int a = 0;
Console.WriteLine("Введите конечное число ");
int b = Convert.ToInt32(Console.ReadLine());
              while (a <= b)
             {
                 if (a%2 ==0)
                    Console.WriteLine("Куб числа " + a);
                    Console.WriteLine(("Число " + a * a * a));
                    a+=2;   
             }