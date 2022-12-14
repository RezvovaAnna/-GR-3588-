// Текст для пользователя 
Console.WriteLine ("Введите число");
string inputNumber = Console.ReadLine();
//Перевод строки в десятиричное число
int number = int.Parse (inputNumber);
// Проверка числа
if (number!=null)
{
    //Делим число на два
    int remainder= number % 2;
    //Сравниваем остаток с 0
    if (remainder == 0)
    {
        //Выводим результат на экран
        Console.WriteLine(number + " - четное");
    }

        else
        {
        Console.WriteLine (number + " - нечетное");
        }
}
