/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.
*/

double[] GetRandomArray(int length, int min, int max)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

double MinElementOfArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double MaxElementOfArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double DifferenceElements(double max, double min)
{
    double dif = max - min;
    return dif;
}

double[] newArray = GetRandomArray(4, -10, 99);
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(newArray);
Console.ResetColor();
double maxElement = MaxElementOfArray(newArray);
double minElement = MinElementOfArray(newArray);
double result = DifferenceElements(maxElement, minElement);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Максимальный элемент массива = {maxElement}, минимальный  = {minElement},");
Console.WriteLine($"разница между максимальным и минимальным элементами = {result} ");
Console.ResetColor();