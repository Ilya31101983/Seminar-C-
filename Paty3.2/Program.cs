//5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите первое число: ");
int n = int.Parse(Console.ReadLine());
int i = -1*n;

while (i < 0)
{
    Console.WriteLine(i);
    i = i + 1;
}
i = 0;

while (i <= n)
{
    Console.WriteLine(i);
    i = i +1;
}