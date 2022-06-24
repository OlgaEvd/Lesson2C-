// Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого числа
//456 -> 46
//782 -> 72
//918 -> 98

void  SnowNumber()

{
int num = new Random().Next (100,1000);
int num1 = num/100;
int num2 = num % 10;
int result = num1 * 10 + num2;
Console.WriteLine(num + " ->" + result);
}
SnowNumber();
