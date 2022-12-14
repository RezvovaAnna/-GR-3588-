// Текст для пользователя
 Console.WriteLine("Является ли одно число квадратом другого?");
Console.Write("Введите числа: ");
// Ввод числа
int firstNumber = int.Parse(Console.ReadLine()??"0");
int secondNumber = int.Parse(Console.ReadLine()??"0");
// Проверяем являются ли квадратами друг друга
bool resultNumber1 = (firstNumber/secondNumber == secondNumber);
bool resultNumber2 = (secondNumber/firstNumber == firstNumber) ;

if (resultNumber1 == true) 
{
    Console.WriteLine (firstNumber+" квадрат "+secondNumber);
}
if (resultNumber2 == true)
{
    Console.WriteLine (secondNumber+" квадрат "+firstNumber);
}
if ((resultNumber1 == false)&&(resultNumber2 == false))
{
    Console.WriteLine ("Числа не являются квадратами друг друга");
}

// Вариант 2
// void TestSQRT(int i, int j)
// {
//     bool result = (i/j ==j);
//     if (result == true)Console.WriteLine("Число "+i+" является квадратом числа "+j);
//     else Console.WriteLine(" Число "+i+" не является квадратом числа "+j);
//  int firstNumber = int.Parse (Console.ReadLine()??"0");
//  int secondNumber = int.Parse (Console.ReadLine()??"0");
// }
// TestSQRT(firstNumber,secondNumber);
// TestSQRT(secondNumber,firstNumber);


//Вариант 3
// Console.WriteLine("является ли одно число квадратом другого ?");
// Console.Write("Введите первое число: ");

// int firstNumber;
// bool isNumber = int.TryParse(Console.ReadLine(), out firstNumber);
// validate(isNumber);

// Console.Write("Введите второе число: ");
// int secondNumber;
// isNumber = int.TryParse(Console.ReadLine(), out secondNumber);
// validate(isNumber);

// Console.WriteLine(isSqrt(firstNumber,secondNumber)? "Да" : "Нет");

// void validate(bool isNumber)
// {
//     if (!isNumber)
//     {
//         Console.WriteLine("Вы ввели не число, выход");
//         Environment.Exit(0);
//     }
// }

// bool isSqrt(int a, int b)
// {
//     return (a*a == b) || (b*b == a) ;
// }

