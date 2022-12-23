//Метод вывода результата
void PrintData(string msg, string res)
{
    Console.WriteLine(msg+res);
}
//Метод чтения данных 
double ReadData(string msg)
{
  Console.Write(msg);
  return double.Parse(Console.ReadLine() ?? "0");
}
//Метод поиска пересечения в координате X
string SearchCross(double b1, double b2, double k1, double k2)
{ string res = string.Empty;
  double resX = (b2 - b1)/(k1-k2);
  double resY = (k2*b1-k1*b2)/(k2-k1);
  return res = $"{resX}; {resY}";
}
// Считываем переменные
double numK1=ReadData("Введите K1: ");
double numK2=ReadData("Введите K2: ");
double numB1=ReadData("Введите В1: ");
double numB2=ReadData("Введите B2: ");
// Проверяем не параллельны ли прямые
  if(numK1==numK2) 
{
 Console.WriteLine("Прямые не пересекаются");
}
  else
{ // Ищем точку пересечения и выводим результат
string result = SearchCross(numB1, numB2, numK1, numK2);
PrintData ("Пересечение: ", result);
}


