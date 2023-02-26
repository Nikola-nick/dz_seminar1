// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine (" введите первое число");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (" введите второе число");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (" введите третье число");
int N3 = Convert.ToInt32(Console.ReadLine());
int max = N1;
if (N1 < N2)
{
    max = N2;
}
if (N2 < N3)
{
    max = N3;
}
Console.WriteLine( max );