//Ввод данных с помощью метода
int quater = ReadData("Введите номер четверти");
printAnswer(quater);

// Метод считывания данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
   return int.Parse(Console.ReadLine() ?? "0");
 
}
//Метод для определения четверти по координатам
void printAnswer(int num)
{if (num >0 && num<5)
{
    if (num==1) Console.WriteLine("x>o,y>0");
    if (num==2) Console.WriteLine("x>o,y<0");
    if (num==3) Console.WriteLine("x<o,y<0");
    if (num==4) Console.WriteLine("x<o,y>0");
}
 else Console.WriteLine("Вы ввели не номер четверти!");
}

