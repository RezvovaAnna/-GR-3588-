// ReadData;
// PrintData
// int SimDigits (int num)
// int result = 0:
// while (num >0)
// result+ = num%10$
// num= num/10:
// return  result;

// Сделать оценку этого алгоритма и алгоритма через стринг при помощи TimeData

int SumDigits (int num)
{
 int result = 0;
 while (num > 0)
  {
    result+=num%10;
    num=num/10;
  }

 return  result;
}

int ReadData (string msg)
{
 Console.WriteLine(msg);
  return int.Parse(Console.ReadLine()??"0");
}


int inputNumber = ReadData ("Введите число: ");

if (inputNumber>9)
{    DateTime d1 = DateTime.Now;
    int res = SumDigits(inputNumber);
    Console.WriteLine(DateTime.Now - d1);
    PrintData("Сумма цифр в числе = ", res);


}
else
{
    Console.WriteLine("Введите другое число");
}





