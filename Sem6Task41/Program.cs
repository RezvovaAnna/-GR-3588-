// Метод вывода результата на экран
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}
// Метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод поиска положительных чисел
int CalPositivNum (int num)
{
  int res = 0;
  while  (num >0)
  {
    if (ReadData("Введите число: ") > 0)
    {
      res++ ;
    }

    num = num - 1;
  }
  return res;
}

int inputNumber = ReadData ("Введите общее количество чисел: ");
int result = CalPositivNum(inputNumber);
PrintData("Кoличество чисел больше нуля: ", result);

