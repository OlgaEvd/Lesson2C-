// See https://aka.ms/new-console-template for more information
//Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли второе число
//кратным первому. Если число 2 не кратно числу 1, то
//программа выводит остаток от деление.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.Write("Введите первое число : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());

int result = a % b;

if (result ==0)

{
        Console.WriteLine($"-> кратно");
}
else

{
    Console.WriteLine($"-> не кратно, остаток {result}");
}


