// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите x: ");
 double x = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine("Введите y: ");
 double y = Convert.ToDouble(Console.ReadLine());

 if ((x > 0) && (y > 0))
    Console.WriteLine("Первая четверть ");
 else if ((x < 0) && (y > 0))
    Console.WriteLine("Вторая четверть ");
 else if((x < 0) && (y < 0))
    Console.WriteLine("Третья четверть ");
 else if ((x > 0) && (y < 0))
    Console.WriteLine("Четвертая четверть ");
else
    Console.WriteLine("Точка лежит на оси ");
 