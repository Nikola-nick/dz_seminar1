// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine (" введите первое число");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (" введите второе число");
int N2 = Convert.ToInt32(Console.ReadLine());
int max = N1;
int min = N2;
if (N1 > N2)
{
    max = N1;
    min = N2;
    
Console.WriteLine( "первое число больше" );
Console.WriteLine( "второе число меньше" );

}
if (N2 > N1)
{
    max = N2;
    min = N1;
    
Console.WriteLine( " второе число больше " );
Console.WriteLine( " первое число меньше " );

}
if (N1 == N2)
{
    max = N1;
    min = N2;
Console.WriteLine( " Числа равны " );
}
