// Удалить вторую цифру трёхзначного числа.
int a;
Console.WriteLine("Введите трехзначное число ");
a = Convert.ToInt32(Console.ReadLine());
int sim = a % 10;
int sim2 = a / 100;
//Console.WriteLine("Вторая цифра трехзначного числа " + sim2);
Console.WriteLine("Число с удаленной второй цифрой " + sim2 + sim);