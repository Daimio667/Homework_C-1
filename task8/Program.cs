// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
int count = 1;

while (count <= numberA)
{
    if (count % 2 ==0)
    Console.Write(count + ".");
    count = count + 1;
}