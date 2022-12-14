// Текст для пользователя
Console.WriteLine("Введите день недели");
//Ввод данных
int inputNumber= int.Parse(Console.ReadLine()??"0");
//Проверка данных
if (inputNumber>0 && inputNumber<8)
{
    if (inputNumber>5)
    {
    Console.WriteLine ("Выходной");
    }
    else 
    {
     Console.WriteLine ("Рабочий день");
    }

}
 else
 {
    Console.WriteLine ("Это не день недели");
 }

      //Вариант 2
    int inputNumber= int.Parse(Console.ReadLine()??"0");
   //   if (inputNumber>0 && inputNumber<8)
   //   {
     //Создаем массив с днями недели
   //   string[] dayOfWeek = new string[7];
   //   dayOfWeek[0] = "понедельник - рабочий день";
  //     dayOfWeek[1] = "вторник - рабочий день";
   //    dayOfWeek[2] = "среда - рабочий день";
   //    dayOfWeek[3] = "четверг - рабочий день";
   //    dayOfWeek[4] = "пятница - рабочий день";
  //      dayOfWeek[5] = "суббота - выходной";
   //     dayOfWeek[6] = "воскресенье - выходной";
//
    //Находим название дня недели по введенному номеру
   //    string outDayOfWeek = dayOfWeek[inputNumber-1];
    //    Вывод ответа
   //    Console.WriteLine(outDayOfWeek);
   //  }
   //   else
   //   {
   //   Console.WriteLine ("Это не день недели");
   //  }

// вар.3 dictionary 
