// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы
Console.WriteLine("напишите k1");
 int k1 = int.Parse(Console.ReadLine());
 Console.WriteLine("напишите b1");
 int b1 = int.Parse(Console.ReadLine());
 Console.WriteLine("напишите k2");
 int k2 = int.Parse(Console.ReadLine());
 Console.WriteLine("напишите b2");
 int b2 = int.Parse(Console.ReadLine());
 int y=0;
 int x=0;
 if(k1==k2) Console.WriteLine($" нет точки ");
 else
 x = (b1-b2)/(k2-k1);
 y = (k2*b1-k1*b2)/(k2-k1);
  Console.WriteLine($"координаты пересечения x-({x}) y-({y})"); 