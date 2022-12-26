//Метод чтения данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double [countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}
// Метод вывода массива на экран
void Print2DArray( double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
         Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
         
        }
        Console.WriteLine();
    }
}
// Метод поиска среднего арифметического в массиве
string AverageCalсulator (double [,] arr)
{   string average = string.Empty; 
    double averageSum = 0;
  
     for ( int j = 0; j<arr.GetLength(0); j++)
  
    {    double sum = 0;
         for (int k = 0; k < arr.GetLength(1); k++)     
         {
         sum = sum + arr [k,j];
         
         }
    averageSum = sum/arr.GetLength(1);
    average = average + averageSum + " ";
    }
    
   return average;
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
double [,] arr2D = Fill2DArray(row, column, 0, 10);
Print2DArray (arr2D);
string result = AverageCalсulator(arr2D);
Console.WriteLine (result);
