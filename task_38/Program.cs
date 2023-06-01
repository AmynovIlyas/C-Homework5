//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Например: 
// [3 7 22 2 78] -> 76
// попытки обучиться заполнению массива вещественными числами не увенчались успехом :(

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100; // умножаем на 100 для получения цифр от 10 до 100
        // если этого не сделать будут выданы значения чисел 0 целых и много цифр после запятой 
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
    foreach(var el in array)
    {
        if(max < el)
        {
            max = el;
        }
        if(min > el)
        {
            min = el;
        }
    }
    Console.Write(max - min);
}

Console.Clear(); // данная команда чистит всё в терминале 
int length = Prompt1("Введите число, задающее размер массива: ");
double[] array = CreateArray(length);
Console.Write($"[{String.Join("; ", array)}] --> "); FindMinMax(array);
