// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите число: ");
int numberA = int.Parse(System.Console.ReadLine());
Console.Write("Введите число: ");
int numberB = int.Parse(System.Console.ReadLine());

if(numberA > numberB)
{
    Console.Write("Первое число больше второго");
}

else
{
    Console.Write("Второе число больше первого");
}