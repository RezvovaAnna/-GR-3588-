// Ввод числа
int number = int.Parse(Console.ReadLine()??"0");
// Проверяем делится ли на 7, 23
int resultNumber1 = number % 7;
int resultNumber2 = number % 23;

if ((resultNumber1==0)&&(resultNumber2==0))
{
    Console.WriteLine ("Да");
}
  else
 {
    Console.WriteLine ("Нет");
 }
