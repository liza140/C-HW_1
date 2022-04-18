// Задача 2: Программа принимает на вход три числа и выдаёт максимальное из этих чисел

int a = 44;
int b = 5;
int c = 78;
int max = a;
if (a < b)
{
    if (c < b) max = b;
    else max = c;
}
else
{
    if (a < c) max = c;
    else max = a;
}
Console.Write("Max = ");
Console.WriteLine(max);
