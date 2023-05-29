// Недорешенная на семинаре задача:
// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void MultiplicationsPairs(int[] array)
{
    int product = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        product = array[i] * array[array.Length - 1 - i];
        Console.Write($"{product}, ");
    }
    if (array.Length % 2 != 0)
    {
        Console.Write($"{array[array.Length / 2]}");
    }
}

int[] array = CreateArray(12, 1, 10);
Console.Write($"[{String.Join(", ", array)}] --> "); MultiplicationsPairs(array);