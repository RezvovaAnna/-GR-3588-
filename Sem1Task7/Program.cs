//Вводим данные через консоль
string inputNumber = Console.ReadLine();
//Проверяем данные
if (inputNumber!=null);
{
   //Переводим число в десятичное
   int inputLine = int.Parse(inputNumber);

   int lastDigit = inputLine % 10;

   // Выводим данные на консоль
   Console.WriteLine (lastDigit);
}