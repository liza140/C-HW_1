// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N = 0;
if (N > 1)
{
    int count = 1;
    while (count < N + 1)
    {
        if (count % 2 == 0) Console.WriteLine(count);
        count++;
    }
}
else Console.WriteLine("Операция невозможна");
