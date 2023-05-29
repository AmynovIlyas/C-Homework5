// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Например:
// [345, 897, 568, 234] -> 2

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int Prompt()
{
    Console.WriteLine("Введите число, задающее длину массива: ");
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void EvenNumbered(int[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            n++;
        }
    }
    Console.Write(n);
}

int length = Prompt();
int[] array = CreateArray(length);
// Console.WriteLine($"[{String.Join(", ", array)}] --> {EvenNumbered(array)}"); - вопрос: при запуске 
// данной командной строки выдается ошибка - "Аргумент 1: не удаётся преобразовать из "void" в "object". Как это исправить?
Console.Write($"[{String.Join(", ", array)}] --> "); EvenNumbered(array);

