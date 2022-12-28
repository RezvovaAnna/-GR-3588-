//Метод чтения данных 
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод вывода результата
void PrintResult( string msg, int res)
{
    Console.Write(msg+res);
}

//Метод поиска суммы между элементами N и M
int NatNumSum(int n, int m)
{    int result=0;
    if (m == 0) result = (n * (n + 1)) / 2;            
    if (n == 0) result = (m * (m+ 1)) / 2;  
    if (n>m) Console.WriteLine("Введите сначало меньшее число, потом большее");   
    if (m>=n) result = n + NatNumSum(n+1, m);
    
 
   return result;
}

int numberN = ReadData("Введите число:");
int numberM = ReadData("Введите число:");
int Sum = NatNumSum(numberN, numberM);
PrintResult("Сумма чисел между ними равна: ", Sum);