// //Считываем данные с консоли
string? inputLine = Console.ReadLine();
// //Проверяем, чтобы данные были не пустыми 

if (inputLine!=null)
{
   int inputNumber = int.Parse(inputLine);
    int outputNumber = inputNumber*inputNumber;
    // int outputNumber = (int)Math.Pow(inputNumber,2);
     // Выводим данные в консоль 
    Console.WriteLine(outputNumber);
    // Console.WriteLine(Math.Pow(int.Parse(inputLine,2));
}


// //Считываем данные с консоли
// string? num1Line = Console.ReadLine();

//  //Парсим введенные числа
// int startNumber = int.Parse(num1Line);

// int num2 = 2;

//  //Выходное значение
// string outLine = string.Empty;

// while (num2 <= startNumber)
// {
//     outLine = outLine + num2 + ", ";
//     num2 = num2 + 2;
// }
// Console.WriteLine(outLine);
