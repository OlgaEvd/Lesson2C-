// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно
//число квадратом другого.

Console.WriteLine("Программа, которая проверяет, является ли второе число квадратом первого");
Console.Write("Введите первое: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());
if (b == a*a)
{
    Console.WriteLine($"Второе число является квадратом первого");
}
else
{
    Console.WriteLine($"Второе число НЕ является квадратом первого");
}