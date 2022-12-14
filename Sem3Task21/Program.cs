﻿int X1 = ReadData("Введите координату Х1: ");
int Y1 = ReadData("Введите координату Y1: ");
int Z1 = ReadData("Введите координату Z1: ");
int X2 = ReadData("Введите координату Х2: ");
int Y2 = ReadData("Введите координату Y2: ");
int Z2 = ReadData("Введите координату Z2: ");

double result = DistanceBetweenPoints(X1, Y1, X2, Y2, Z1, Z2);

PrintData("Расстояние между точками: ", result);

//Метод читает данные от пользователя
int ReadData(string msg)
 {
     Console.WriteLine(msg);
     return int.Parse(Console.ReadLine() ?? "0");
 }

//Метод находит расстояние между точками на плоскости
double DistanceBetweenPoints(double x1, double y1, double x2, double y2, double z1, double z2)
 {
     double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)*(z1-z2));
     return distance;
 } 

//Метод выводит данные пользователю
void PrintData(string msg, double result)
 {
     Console.WriteLine(msg + result);
 }
