//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberB == numberA/numberB)
{
    Console.WriteLine("Верно");
}
else
{
    Console.WriteLine("Не верно");
}

