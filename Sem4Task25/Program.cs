


int ReadData (string msg)
{
 Console.WriteLine(msg);
 return int.Parse(Console.ReadLine()??"0");
}

void PrintData(string msg, int res)
{
 Console.WriteLine(msg + res);
}

int getPow (int num, int pow)
{
  int result = 1;
    for(int i=0; i<pow; i++)
    {
        result = num * result;
    }
    return result;
}

 
 int number = ReadData("Возвести число ");
 int pow = ReadData("в стeпень ");
 int res = getPow(number, pow);
 PrintData("= ", res);

 