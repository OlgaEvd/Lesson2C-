// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void DayOfTheWeek (int day) 
{
  if (day == 6 || day == 7) {
  Console.WriteLine("Ура - выходной!!!");
  }
  else if (day < 1 || day > 7) {
    Console.WriteLine("такого дня недели не существует");
  }
  else Console.WriteLine("Работать негры, выходной ещё не наступил"); //да простят меня наши самые "загорелые" люди планеты
}

DayOfTheWeek(day);
