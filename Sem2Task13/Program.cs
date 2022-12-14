//Текст для пользователя
 Console.WriteLine("Введите трехзначное число");
//Ввод данных
int inputNumber= int.Parse(Console.ReadLine()??"0");
//Проверка данных
if (inputNumber>99)
{
string digits = inputNumber.ToString();
char[] numberArray = digits.ToCharArray();
Console.WriteLine (numberArray[2]);
}
else
{
Console.WriteLine("Нет третьей цифры в числе");
}

// Второй вариант
//
//