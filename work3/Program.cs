Console.WriteLine("Будет создан массив длиной A в диапвзоне 0-A");
Console.Write("Введите любое число (A): ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];

for (int i = 0; i < x; i++)
{
 array[i] = new Random().Next(x+1);
 Console.Write(array[i] + "; ");
}
Console.WriteLine();



