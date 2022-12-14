//Вводим данные с консоли
string inputLine = Console.ReadLine();
// Проверяем данные
if (inputLine!=null)
{
    //Переводим число в десятичное
    int inputNumber = int.Parse(inputLine);
    int startNumber = inputNumber*(-1);
    //Выходное значение
    string outLine = string.Empty;

    while (startNumber<inputNumber)
    {
        outLine = outLine + startNumber + ", ";
        startNumber++;
        // startNumber= startNumber + 1;
    }
    outLine = outLine + inputNumber;
    //Выводим данные на консоль
    Console.WriteLine(outLine);
}   
