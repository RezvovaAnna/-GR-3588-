// Создаем рандомайзер
System.Random numberSintesator = new System.Random();
// Получаем случайное число
int randomNumber = numberSintesator.Next(100,1000);
//Выводим на консоль число
Console.WriteLine(randomNumber);
// Получаем 1 и 2 число
int firstNumber = randomNumber/100;
int secondNumber = randomNumber%10;
//Создаем 3 число
int resultNumber = firstNumber*10 + secondNumber;
// Вывод на консоль
 Console.WriteLine (resultNumber);

//Вариант 2
//int resultNumber = ((randomNumber/100)*10 + randomNumber%10);
// Вывод на консоль
//   Console.WriteLine(resultNumber);

//Вариант 3
// System.Random random = new System.Random ();
//int randomNumber = random.Next(100,1000);
//Console.WriteLine (randomNumber);
//string value = randomNumber.ToString();
//char[] numberArray = value.ToCharArray();
//Console.WriteLine(numberArray[0]+" "+ numberArray[2]);


