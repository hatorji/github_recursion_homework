// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("] => ");
}

void PrintReversedArray(int[] array, int index = 0)
{
    if (index == array.Length) return;
    PrintReversedArray(array, index + 1);
    Console.Write($"{array[index]} ");

}

Console.WriteLine("Input array lengh");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(n, 0, 40);// метод скопированн из семминаров, чтобы не создавать массив ручками.
PrintArray(arr);

PrintReversedArray(arr);