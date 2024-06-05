// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

using System.Runtime.InteropServices.Marshalling;

void AllNaturalNumbers(int m, int n)
{
    if (m > n) // ветвление создано, чтобы сохранить последовательность не зависимо какое число больше
    {
        if (m == n) return; 
        Console.Write($"{m} ");
        AllNaturalNumbers(m - 1, n);       
    }
    else
    {
        if (n == m) return;
        AllNaturalNumbers(m, n - 1);
        Console.Write($"{n} ");
    }
}

Console.Write("Введите значение M: ");
int startM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int finishN = Convert.ToInt32(Console.ReadLine());


if(startM > finishN) // Без добавления "-1" к границе отрезка рекурсия съедала последнее число в переборе
    {
        AllNaturalNumbers(startM, finishN - 1);
    }
else
    {
        AllNaturalNumbers(startM - 1, finishN);
    }
