//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Например: 
// [3 7 22 2 78] -> 76
// попытки обучиться заполнению массива вещественными числами не увенчались успехом :(

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 101); 
    }
    return array;
}


int Prompt1(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void FindMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
        if(min > array[i])
        {
            min = array[i];
        }
    }
    Console.Write(max - min);
}

int length = Prompt1("Введите число, задающее размер массива: ");
double[] array = CreateArray(length);
Console.Write($"[{String.Join(", ", array)}] --> "); FindMinMax(array);
