//Console.WriteLine("Введите координату Х");
//int coordX = int.Parse(Console.Readline()??"0");
//Console.WriteLine("Введите координату Y");
//int coordY = int.Parse(Console.Readline()??"0");

int coordX = ReadData("Введите координату Х");
int coordY = ReadData("Введите координату Y");
PrintQuaterTest();
//Создаем метод для считывания данных с консоли
int ReadData(string msg)
{
     Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Создаем метод для определения четверти по координатам точки
void PrintQuaterTest()
{
if(coordX>0&&coordY>0) Console.WriteLine("Точка в четверти 1");
if(coordX>0&&coordY<0) Console.WriteLine("Точка в четверти 2");
if(coordX<0&&coordY<0) Console.WriteLine("Точка в четверти 3");
if(coordX<0&&coordY>0) Console.WriteLine("Точка в четверти 4");
}


