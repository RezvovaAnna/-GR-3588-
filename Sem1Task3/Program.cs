//Вводим данные
string? inputLine = Console.ReadLine();
//Проверяем данные
if (inputLine!=null);

{   
//Создаем массив с днями недели
//string[] dayOfWeek = new string[7];
//dayOfWeek[0] = "понедельник";
//dayOfWeek[1] = "вторник";
//dayOfWeek[2] = "среда";
//dayOfWeek[3] = "четверг";
//dayOfWeek[4] ="пятница";
//ddayOfWeek[5] = "суббота";
//dayOfWeek[6] = "воскресение";
//Переводим число в десятичное
int inputNumber = int.Parse(inputLine);
// Решаем через кейс
//string outDayofWeek = dayOfWeek[inputNumber - 1];
//string outDayofWeek = string.Empty;
//switch (inputNumber)
//{
  //case 1: outDayofWeek = "понедельник"; break;
  //case 2: outDayofWeek = "вторник"; break;
  //case 3: outDayofWeek = "среда"; break;
  //case 4: outDayofWeek = "четверг"; break;
  //case 5: outDayofWeek = "пятница"; break;
  //case 6: outDayofWeek = "суббота"; break;
  //case 7: outDayofWeek = "воскресение"; break;
  //default: outDayofWeek = "это не день недели"; break;
//}

string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));


    // Выводим данные в консоль 
    Console.WriteLine(outDayOfWeek);
}

