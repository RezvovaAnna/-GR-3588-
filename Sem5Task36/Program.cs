//Метод, генерирующий массив
int[] GenArray(int length, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}
// Метод вывода результата на экран
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

// Метод, выводящий массив на экран
void PrintArray(int[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}
// Метод, подсчета суммы элементов с нечетным индексом

int OddNumSum (int[] arr)
{
    int sum = 0;
    int i=1;
    while(i < arr.Length)
    { 
     sum=sum + arr[i];
     i=i+2;
    }
    return sum;
}

int[] array = GenArray(6, 1, 10);
PrintArray(array);
int result = OddNumSum(array);
Console.WriteLine();
PrintData("Сумма чисел на нечетных позициях в массиве: ", result);
