// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Печать цветного массива
void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[matrix[i,j]%15];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}



// Генерируем двумерный массив, заполненный случайными числами
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// Метод вывода результата на экран
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Метод поиска строчки с минимальной суммой элементов
int MinSumRow(int[,] arr)
{
    int sum =0;
    int MinRow = int.MaxValue; 
    int index = 0;

     for (int i = 0; i < arr.GetLength(0); i++)
    {     
        
        for (int j = 0; j < arr.GetLength(1); j++)
         {sum = sum + arr[i,j]; }

         Console.WriteLine(sum);

        if (sum < MinRow)
        {
            MinRow = sum;
            index = i;
        }   
       
           
    }   
       
return index;
}

int row = ReadData("Введите количество строк ");                                 
int column = ReadData("Введите количество столбцов ");                           
int[,] arr2D = Fill2DArray(row, column, 1, 10);   
Print2DArrayColor(arr2D);    
Console.WriteLine();  
int result = MinSumRow(arr2D);
PrintData("Строка минимальной суммы ",result);

