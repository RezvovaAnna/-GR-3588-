//Метод чтения данных 
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Метод вывода данных
void PrintData(string msg, int result)
{
    Console.WriteLine(msg + result);
}

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int [countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}
// Метод поиска значаения в двумерно массиве
int SearchNum (int[,] matrix, int row, int column)
{    int result = -1;
     if (row < matrix.GetLength(0))
     {
        if(column < matrix.GetLength(1))
       
        {
          result = matrix[row,column];
        }
      }
    return result;
}
// Метод вывода массива на экран    
void Print2DArray(int[,] matrix)
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

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);
int row1 = ReadData("Введите стороку: ");
int column1 = ReadData("Введите столбец: ");
int result = SearchNum (arr2D, row1, column1);
if (result > -1)
{
   PrintData("Ваше число: ", result);
}
else 
{
    Console.WriteLine("Нет такой позиции");
}

