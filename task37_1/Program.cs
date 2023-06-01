// Решение задачи 37 путем составления массива, заполненного произведениями пар чисел
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

void ArrayProduct(int[] array)
{
    int[] result = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < result.Length; i++)
    {
        if (i == array.Length - 1 - i)
        {
            result[i] = array[i];
        }
        else
        {
            result[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    Console.Write($"[{String.Join(", ", result)}]");
}

int[] array = CreateArray(11, 1, 10);
Console.Write($"[{String.Join(", ", array)}] --> "); ArrayProduct(array);

