/* Задача 8: напишите программу, которая на вход принимает число (N),
а на выходе показывает все четные числа от 1 до N.*/

int N = new int();
Console.WriteLine("Введите число");
N = Convert.ToInt32(Console.ReadLine());
int i = 0;
Console.Write("Все четные числа от 1 до ");
Console.WriteLine(N);
while (i < N - 1)
{
    i += 2;
    Console.WriteLine(i);
}
