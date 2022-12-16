Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Вы ввели чётное число");
}
else
{
    Console.WriteLine("Вы ввели нечётное число");
}