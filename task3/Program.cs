/* Задача 6: напишите программу, которая на вход принимает число и выдает,
является ли число четным.*/

int Num = new int();
Console.WriteLine("Введите число");
Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Num % 2 == 0);
