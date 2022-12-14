// Текст для пользователя
{
Console.WriteLine("Введите три числа");
// Ввод чисел
string inputNumberFirst = Console.ReadLine();
string inputNumberSecond = Console.ReadLine();
string inputNumberThird = Console.ReadLine(); 
 //Проверка чисел
if (inputNumberFirst!=null&&inputNumberSecond!=null&&inputNumberThird!=null)
 //Сравниваем числа
{   //Перевод строк в числа
    int numberFirst=int.Parse(inputNumberFirst);
    int numberSecond=int.Parse(inputNumberSecond);
    int numberThird=int.Parse(inputNumberThird);
    int numberMax = 0;

  if (numberFirst > numberSecond)
  {
    numberMax = numberFirst;
 }
  else
 {
   numberMax = numberSecond;
 }
      if (numberThird > numberMax)
     {
       numberMax = numberThird;
     }

// Вывод ответа
Console.WriteLine("Больше " + numberMax);
}}

//Второй вариант решения
//string inputNumberFirst = Console.ReadLine ();
//string inputNumberSecond = Console.ReadLine ();
//string inputNumberThird = Console.ReadLine ();
//if (inputNumberFirst!=null&&inputNumberSecond!=null&&inputNumberThird!=null)
// {
//int numberFirst = int.Parse(inputNumberFirst);
//int numberSecond = int.Parse(inputNumberSecond);
//int numberThird = int.Parse(inputNumberThird);
//int numberMax1= Math.Max(numberFirst,numberSecond);
//int numberMax2 = Math.Max(numberThird, numberSecond);
//int numberMax= Math.Max (numberMax1, numberMax2);
//Console.WriteLine("Больше " + numberMax);
// } }