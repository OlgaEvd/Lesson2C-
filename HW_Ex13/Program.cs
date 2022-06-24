//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет");
Console.WriteLine("");
Console.Write("Введите число : ");


int num = Convert.ToInt32(Console.ReadLine());
string result = Convert.ToString(num);

if (result.Length > 2)
{
    Console.WriteLine("третья цифра -> " + result[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}


