
int ReadData (string msg)
{
  Console.WriteLine (msg);
  return int.Parse(Console.ReadLine()??"0");
}

void PrintData (string msg, int [] result)
{
   Console.WriteLine(msg);
   PrintArr(result);
}

int[] GenArr(int a, int b)
{
    Random rnd = new Random();
    int num = 8;
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(a,b+1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int arrStart = ReadData("Введите минимальное значение в массиве: ");
int arrFinish = ReadData("Введите максимальное значение в массиве: ");
int[] arr = GenArr(arrStart, arrFinish);
PrintData("Сгененрированный массив:",arr);
