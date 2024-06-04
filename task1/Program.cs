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

int startM = 1;
int finishN = 9;
if(startM > finishN) // Без добавления "-1" к границе отрезка рекурсия съедала последнее число в переборе
    {
        AllNaturalNumbers(startM, finishN - 1);
    }
else
    {
        AllNaturalNumbers(startM - 1, finishN);
    }
