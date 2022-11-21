/* Задача 4: напишите программу, которая принимает на вход три числа
и выдает максимальное из этих чисел */

int Num1 = new int();
Console.WriteLine("Введите число");
Num1 = Convert.ToInt32(Console.ReadLine());
int Num2 = new int();
Console.WriteLine("Введите число");
Num2 = Convert.ToInt32(Console.ReadLine());
int Num3 = new int();
Console.WriteLine("Введите число");
Num3 = Convert.ToInt32(Console.ReadLine());
int max = Num1;
if (Num1 > max) max = Num1;
if (Num2 > max) max = Num2;
if (Num3 > max) max = Num3;
Console.Write("Максимальное число ");
Console.WriteLine(max);