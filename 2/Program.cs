
Console.WriteLine("Введите первое число");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

int max = 0;
if(a > b)
{
    max = a;
    Console.Write($"max = {max}");
}
else if(b > a)
{
    max = b;
    Console.Write($"max = {max}");
}
else
{
    Console.Write($"Числа {a} и {b} равны");
}
