// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("введите число A");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число B");
int b = int.Parse(Console.ReadLine()!);
int banan = a;
int i = 1;
while (i < b)
{
banan = banan * a;
i++;
}
Console.WriteLine("A в степени B равно: " + banan);