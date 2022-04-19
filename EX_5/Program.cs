// Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
int N = 4;
int count = -N;
if (N > 0)
{
    while (count < N + 1)
    {
        Console.WriteLine(count);
        count++;
    }
}
else
{
    while (count > N - 1)
    {
        Console.WriteLine(count);
        count = count - 1;
    }
}