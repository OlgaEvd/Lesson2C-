//Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

int rndNum = new Random().Next(10,100);
//Console.WriteLine($"Случайное число из отрезка от 10 до 99 =  {rndNum}");
//int firstDigit = rndNum/10;
//int secondDigit = rndNum % 10;

//Console.WriteLine ($"Наибольшая цифра числа {rndNum} = ");

//Вариант1
//if(firstDigit > secondDigit) Console.WriteLine(firstDigit);
//else Console.WriteLine(secondDigit);

//Вариант 2
//int result = firstDigit > secondDigit ? firstDigit : secondDigit;
//Console.WriteLine(result);


//Вариант 3  - через функцию
int MaxDigit(int num)
{
int firstDigit = num/10;
int secondDigit = num %10;
if(firstDigit == secondDigit) return 0;
return firstDigit > secondDigit ? firstDigit : secondDigit;
}
 //rndNum = 88;
int maxDigit = MaxDigit(rndNum);
string result = maxDigit > 0 ? maxDigit.ToString(): "цифры одинаковые";

Console.WriteLine($"Наибольшие цифра числа  {rndNum} - {result}");