// Задача 14: Напишите программу, которая принимает на
//вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Кратно ли число 7 и 23 одновременно");
Console.WriteLine("");
Console.Write("Введите число : ");

int number = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;

if (number % a == 0 && number % b == 0)
{
Console.WriteLine("Кратно обоим числам");
}

else if (number % a == 0) 
{
    Console.WriteLine($"кратно только числу {a}");
}

else if (number % b == 0) 
{
    Console.WriteLine($"кратно только числу {b}");
}
else
{
    Console.WriteLine(" Не кратно ни одному числу");
}