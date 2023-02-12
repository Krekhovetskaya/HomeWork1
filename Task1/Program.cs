Console.Write ("Введите число ");
int numberA = int.Parse (Console.ReadLine()!);
Console.Write ("Введите второе число ");
int numberB = int.Parse (Console.ReadLine()!);
Console.Write ("Введите третье число ");
int numberE = int.Parse (Console.ReadLine()!);
int max = numberA;

if (numberA > max)
{
    max = numberA;
}
if (numberB > max)
{
    max = numberB;
}
if (numberE > max)
{
    max = numberE;
}
Console.Write ("max = ");
Console.WriteLine (max);
