/* Задача 2: напишите программу, которая на вход принимает два числа
и выдает, какое число большее, а какое меньшее.*/

int Num1 = new int();
Console.WriteLine("Введите число");
Num1 = Convert.ToInt32(Console.ReadLine());
int Num2 = new int();
Console.WriteLine("Введите число");
Num2 = Convert.ToInt32(Console.ReadLine());
if (Num1 > Num2)
{
    Console.WriteLine(Num1);
}
else
{
    Console.Write("большее число ");
    Console.WriteLine(Num2);
}