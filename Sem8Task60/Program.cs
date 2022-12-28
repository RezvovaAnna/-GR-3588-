int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Метод печати трехмерного массива
void Print3DArray (int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      //Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        //Console.WriteLine($"{arr[i,j,k]} {(}{i}{j}{k}{)};");
        Console.Write ( $"{arr[i,j,k]}({i},{j},{k}) ");
      }
       Console.WriteLine();
    }
  }
}

// Генерируем трехмерный массив, заполненный случайными числами
int[,,] Fill3DArray(int countRow, int countColumn, int countRow2, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,,] array3D = new int[countRow, countColumn, countRow2];
    for (int i = 0; i < countRow; i++)
    {   for (int k = 0; k <countRow2; k++)
        {
        for (int j = 0; j < countColumn; j++)
        {
            array3D[i, k, j] = rand.Next(topBorder, downBorder + 1);
        }
    }  }
    return array3D;
}

int row = ReadData("Введите количество строк: ");                                 
int column = ReadData("Введите количество столбцов: ");     
int row2 = ReadData("Введите еще одно число для массива: ");                       
int[,,] arr3D = Fill3DArray(row, column, row2, 10, 99);
Print3DArray(arr3D);
Console.WriteLine();