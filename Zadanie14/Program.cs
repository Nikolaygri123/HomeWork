//  Найти третью цифру числа или сообщить, что её нет.
//int a;
//Console.WriteLine("Введите число ");
//a =Convert.ToInt32(Console.ReadLine());
//if (a < 100)
//{
  //  Console.WriteLine("В числе нет третьей цифры ");
//}
//if (a >= 100 && a <= 999)
//{
  //  int sim = a % 10; 
    //Console.WriteLine("Третья цифра числа " + sim);
//}
//if (a >= 1000 && a <= 9999)
//{
  //  int sim2 = a % 100;
    //int sim3 = sim2 / 10;
    //Console.WriteLine("Третья цифра числа " + sim3);
//}
//if ( a>= 10000 && a <= 99999)
//{
  //  int sim4 = a % 1000;
    //int sim5 = sim4 / 100;
    //Console.WriteLine("Третья цифра числа " +  sim5);
//}

Random rnd = new Random();
int a = rnd.Next(1, 200);
Console.WriteLine(a);
string b = Convert.ToString(a);
if (b.Length > 2)
{
    Console.WriteLine(b[2]);
}
else 
Console.WriteLine("Нет третьей цифры ");