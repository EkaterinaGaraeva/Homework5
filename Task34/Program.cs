/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] GetArray(int length)
{
    int[] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(100, 1000);
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

int NumberOfEvenNumbers(int[] arrayOfNumbers)
{
    int count = 0;
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        int result = arrayOfNumbers[i] % 2;
        if (result == 0)
        {
            count++;
        }
    }
    return count;
}

int[] arr = GetArray(10);
Console.Write("Исходный массив: ");
PrintArray(arr);

int cou = NumberOfEvenNumbers(arr);
Console.Write($"Количество чётных чисел в массиве: {cou}");
Console.WriteLine();
