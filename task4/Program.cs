// Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.
//2, 3, 7 -> 7
//44 78 5 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число: ");
int numberA = int.Parse(System.Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(System.Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = int.Parse(System.Console.ReadLine());

if(numberC > numberB && numberC > numberA)
{
    Console.Write("Третье число больше двух первых");
}

else if (numberB > numberA && numberB > numberC)
{
    Console.Write("Второе число больше первого и третьего");
}

else if (numberA > numberB && numberA > numberC)
{
    Console.Write("Первое число больше второго и третьего");
}