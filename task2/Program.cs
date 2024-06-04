// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.




Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0)
{
    Console.Write("Введите два неотрицательных числа, эт ж Аккерман, ну");
    return;
}
int akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return akkerman(n - 1, 1);
    else return akkerman(n - 1, akkerman(n, m - 1));
}

Console.Write($"Результат функции Аккермана равен {akkerman(n, m)} ");