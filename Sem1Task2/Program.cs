// Текст для пользователя
 Console.WriteLine ("Введите два числа");
// Ввод чисел 
string inputNumberFirst = Console.ReadLine ();
string inputNumberSecond = Console.ReadLine ();
// Перевод строк в десятичные числа
int NumberFirst = int.Parse (inputNumberFirst);
int NumberSecond = int.Parse (inputNumberSecond);
// Проверка, что числа не равны нулю
if (inputNumberFirst!=null&&inputNumberSecond!=null);
// Сравниваем числа
{
    if (NumberFirst > NumberSecond)
    //Вывод ответа
    {
    Console.WriteLine (NumberFirst+" больше " +NumberSecond);
    }
     // Вывод ответа
    else
    {
    Console.WriteLine (NumberSecond+" больше "+ NumberFirst);
    }
}

