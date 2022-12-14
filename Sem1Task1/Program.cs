//Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
// Проверяем, что не равно нулю
if (num1Line!=null&&num2Line!=null)
{
    //Переводим числа в десятичные
    int num1 = int.Parse (num1Line);
    int num2 = int.Parse (num2Line);
    // Сравниваем числа
    if (num1 == num2 * num2)
    {
        //Вывод данных на консоль
        Console.WriteLine ("Первое число квадрат второго");
    }

    else
    {
        ////Вывод данных на консоль
        Console.WriteLine ("Первое число не квадрать второго");
    }
}