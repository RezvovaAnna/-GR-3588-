
//Создаем метод для считывания данных с консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
   return int.Parse(Console.ReadLine()??"0");

}     
// //Метод выводит данные пользователю
// void PrintData(string msg, int result)
//  {
//    Console.WriteLine(msg + result);
//  }
 // Метод определения палидрома
 void PalindromTest(int num)  
  {  if  ((num/10000 == num%10)&&((num/1000)%10==(num/10)%10))
      {
      Console.WriteLine(num+ " - это палиндром");
      }
         else
         {
       Console.WriteLine(num+ " - это не палиндром");
         }
  }
int inputNumber = ReadData("Введите пятизначное число:");
// Проверка данных
if (inputNumber>9999&&inputNumber<100000)
{
  PalindromTest(inputNumber);
}
else 
{
  Console.WriteLine("Введите другое число");
}

// палидром
//int num = ReadData;
//bool result = PalindromTest (num);
//PrintData (result);
//bool PalindromTest (int num)
//{   result=(num/10000 == num%10)&&((num/1000)%100==(num/100)%10);
  //  bool result = false;
//}

