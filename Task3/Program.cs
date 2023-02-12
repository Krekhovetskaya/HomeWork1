Console.Write ("Введите число ");
int numberA = int.Parse (Console.ReadLine()!);
int i = 1;
while (i <= numberA)
{
   if (i % 2 == 0)
   {
    Console.Write(i + " ");
   }
   i++;
}