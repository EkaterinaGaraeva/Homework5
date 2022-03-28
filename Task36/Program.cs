/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int length, int deviation)
{
    int[] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(-deviation, deviation + 1);
    }
    return arrayOfNumbers;
}

void PrintArray(int[] arrayOfNumbers)
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

int SumOfElements(int[] arrayOfNumbers)
{
    int sum = 0;
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        int result = i % 2;
        if (result == 1)
        {
            sum = sum + arrayOfNumbers[i];
        }
    }
    return sum;
}

int[] arr = GetArray(10, 9);
Console.Write("Исходный массив: ");
PrintArray(arr);

int sum = SumOfElements(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");
