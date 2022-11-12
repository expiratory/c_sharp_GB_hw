// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.Clear();

// void GetRandomArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
// }

// int CountOfPlus(int[] arr)
// {
//     int countPlus = 0;
//     for (int j = 0; j < arr.Length; j++)
//     {
//         if (arr[j]%2 == 0) countPlus++;
//         else continue;
//     }
//     return countPlus;
// }

// int[] arrayNew = new int [15];
// GetRandomArray(arrayNew);
// int count = CountOfPlus(arrayNew);

// Console.WriteLine($"[{String.Join(", ", arrayNew)}]");
// Console.WriteLine($"Количество четных чисел в массиве равняется {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// Console.Clear();

// void GetRandomArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 16);
//     }
// }

// int SumOfOdds(int[] arr)
// {
//     int sum = 0;
//     for (int j = 1; j < arr.Length; j++)
//     {
//         sum += arr[j];
//         j++;
//     }
//     return sum;
// }

// int[] arrayNew = new int [15];
// GetRandomArray(arrayNew);
// int oddSum = SumOfOdds(arrayNew);

// Console.WriteLine($"[{String.Join(", ", arrayNew)}]");
// Console.WriteLine($"Сумма элементов массива с нечетными индесками равняется {oddSum}");

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

void GetRandomArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        double rnd = -15 + new Random().NextDouble() * (16+15);
        array[i] = Math.Round(rnd, 3);
    }
}

double MaxMinDifference(double[] array)
{
    double min = 0;
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
        else continue;
    }
    double difference = max - min;
    return difference;
}

double[] arrayNew = new double [15];
GetRandomArray(arrayNew);
double diff = Math.Round(MaxMinDifference(arrayNew), 3);

Console.WriteLine($"[{String.Join("; ", arrayNew)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {diff}");