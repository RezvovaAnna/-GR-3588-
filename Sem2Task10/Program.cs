// Текст для пользователя
Console.WriteLine ("Введите трехзначное число");
//Ввод данных
int inputNumber= int.Parse(Console.ReadLine()??"0");
//Проверка данных
if (inputNumber<1000 && inputNumber>99)
{
  int result  = inputNumber / 10;
  result= result % 10;
  //Вывод результата на консоль
  Console.WriteLine(result);  
}
else
{
    Console.WriteLine ("Неправильное число");
}
