//Метод, генерирующий массив
double [] GenArray(int length)
{
    Random rnd = new Random();
     double[] outArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        outArray[i] = new Random().NextDouble();
    }
    return outArray;
}
// Метод вывода результата на экран
void PrintData(string res, double value)
{
    Console.WriteLine(res + value);
}

// Метод, выводящий массив на экран
void PrintArray(double[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "; ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

// Метод поиска разницы между минимальным и максимальным числом в массиве

    double DiffMaxMinx(double[] arr)
{    
    double min= double.MaxValue;
     double max = double.MinValue;
     
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i]>max)
    {
         max = arr[i];
    }
    if (arr[i]<min)
    {
       min = arr[i];
    }
  }
  double res =max-min;
  return res; 
   
}

double[] newArray = GenArray(10);
PrintArray(newArray);
Console.WriteLine();
double result = DiffMaxMinx (newArray);
PrintData("Разница между максимальным и минимальным элементом массива: ", result);

