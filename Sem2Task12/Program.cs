// Ввод числа
int firstNumber = int.Parse(Console.ReadLine()??"0");
int secondNumber = int.Parse(Console.ReadLine()??"0");
// Ищем остаток от деления
int resultNumber = secondNumber / firstNumber;
// Выводим результат на консоль
if  (resultNumber == 0)
{
   
    Console.WriteLine ("Второе число делится на первое без остатка");
}
else
{
    Console.WriteLine ("Второе число не кратно первому. Остаток от деления " + resultNumber);
}
