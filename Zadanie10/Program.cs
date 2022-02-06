//  Показать вторую цифру трёхзначного числа.
int a;
Console.WriteLine("Введите трехзначное число ");
a = Convert.ToInt32(Console.ReadLine());
int sim = a / 10;
int sim2 = sim % 10;
Console.WriteLine("Вторая цифра трехзначного числа " + sim2);