// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Например:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void SumUnevenNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    Console.Write($"{sum} (сумма элементов массива, стоящих на нечётных позициях)");
}

int length = Prompt("Введите число, задающее размер массива: ");
int min = Prompt("Введите значение минимального элеменат массива: ");
int max = Prompt("Введите значение максимального элемента массива: ");
int[] array = CreateArray(length, min, max);
Console.Write($"[{String.Join(", ", array)}] --> "); SumUnevenNumbers(array);
