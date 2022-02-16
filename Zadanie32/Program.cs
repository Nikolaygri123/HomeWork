// Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран
int[] massiv = new int[8];
int lenght = massiv.Length;
for( int index=0; index<lenght; index++)
{
    massiv[index] = new Random().Next(0,2);
    Console.Write(massiv[index] + " " );
}
