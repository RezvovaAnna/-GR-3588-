//Текст для пользователя
Console.WriteLine("Введите число");
//Ввод числа
string inputNumber = Console.ReadLine();
//Перевод числа в десятиричное 
int number = int.Parse(inputNumber);
//Проверка числа 
if (number!=null)
// Поиск четных чисел
{ 
  string outputNumber = string.Empty;
  int count = 2;
  while (count<number)
{
    outputNumber = outputNumber + count + ", ";
    count = count + 2;
}
// Включаем или не включаем само число
int remainder = number % 2;
if (remainder== 0)
{
    Console.WriteLine(outputNumber+""+number);
}
  else
   {
    Console.WriteLine(outputNumber);
   }
}
