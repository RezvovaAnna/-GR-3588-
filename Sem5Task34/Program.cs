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

// Тест на четные числа
bool EvenTest (int num)
{
    bool res = false;
    if (num%2==0)
    {
        res = true;
    }
    return res;

}
// Метод подсчета четных чисел

int EvenCount (int[ ]arr)
{   int count=0;
    for (int i = 0; i < arr.Length; i++)

        {    
            
            if (EvenTest(arr[i]) == true)
            {
                count= count+1;
            }
            else
            {
                count = count+0;
            }
        }
        return count;
} 

int[] array = GenArray(10,100,150);
PrintArray(array);
int result = EvenCount(array);
Console.WriteLine();
PrintData("Количество четных элементов в массиве: ", result);