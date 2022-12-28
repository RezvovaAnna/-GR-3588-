
// Чтение данных с консоли
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод вывода данных на консоль
void PrintResult( string msg, int res)
{
    Console.Write(msg+res);
}
// Метод, применяющий функцию  Аккермана
int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
       return n + 1;
    }
   else if (n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
 }
   else
   {
    return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
   }
}

int numberM = ReadData("Введите число M: ");
int numberN = ReadData("Введите число N: ");
//Проверка чисел
if (numberM<0 || numberN<0)
{
    Console. WriteLine("Введите положительные числа");
}
else
{
    int result = FunctionAkkerman (numberM, numberN);
    PrintResult ("", result);
}
