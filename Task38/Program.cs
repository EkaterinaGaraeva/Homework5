/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76
*/

double[] GetArray(int length, double deviation)
{
    double[] arrayOfNumbers = new double[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().NextDouble() * (deviation - (-deviation)) + (-deviation);
        arrayOfNumbers[i] = Math.Round(arrayOfNumbers[i], 2);
    }
    return arrayOfNumbers;
}

void PrintArray(double[] arrayOfNumbers)
{
    Console.Write("[");
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        Console.Write(arrayOfNumbers[i]);
        if (i != arrayOfNumbers.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

double MaxElement(double[] arrayOfNumbers)
{
    double max = arrayOfNumbers[0];
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        if (arrayOfNumbers[i] > max)
        {
            max = arrayOfNumbers[i];
        }
    }
    return max;
}

double MinElement(double[] arrayOfNumbers)
{
    double min = arrayOfNumbers[0];
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        if (arrayOfNumbers[i] < min)
        {
            min = arrayOfNumbers[i];
        }
    }
    return min;
}

double[] arr = GetArray(10, 9);
Console.Write("Исходный массив: ");
PrintArray(arr);

double max = MaxElement(arr);
double min = MinElement(arr);
double differenceMaxMin = max - min;
differenceMaxMin = Math.Round(differenceMaxMin, 2);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {differenceMaxMin}");
