// Задача 47: Задайте двумерный массив размером m на n,
// заполненный случайными вещественными числами.

// Console.Clear();

// int TrueN()
// {
//     bool BoolN = Int32.TryParse(Console.ReadLine(), out int N);
//     while (BoolN == false)
//     {
//         Console.WriteLine("Вы ввели то, что не является числом. Попробуйте заново: ");
//         BoolN = Int32.TryParse(Console.ReadLine(), out N);
//     }
//     return N;
// }

// void FillAndPrintArray(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = -10 + new Random().NextDouble() * (10+10);
//             Console.Write($"{arr[i, j],8:f3} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите число m: ");
// int m = TrueN();
// Console.WriteLine("Введите число n: ");
// int n = TrueN();
// Console.WriteLine();

// double[,] array = new double[m, n];
// FillAndPrintArray(array);
// Console.WriteLine();

// Задача 50: Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.

// Console.Clear();

// int TrueN()
// {
//     bool BoolN = Int32.TryParse(Console.ReadLine(), out int N);
//     while (BoolN == false)
//     {
//         Console.WriteLine("Вы ввели то, что не является числом. Попробуйте заново: ");
//         BoolN = Int32.TryParse(Console.ReadLine(), out N);
//     }
//     return N;
// }

// void FillAndPrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 10);
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindElement(int[,] numbers, int iOne, int iTwo)
// {
//     bool finded = false;
//     for (int k = 0; k < numbers.GetLength(0); k++)
//     {
//         for (int l = 0; l < numbers.GetLength(1); l++)
//         {
//             if (k == iOne && l == iTwo)
//             {
//                 Console.WriteLine($"Указанному индексу соответствует элемент со значением {numbers[k, l]}");
//                 finded = true;
//             }
//         }
//     }
//     if (finded == false) Console.WriteLine("Элемента с таким индексом не существует");
// }

// Console.WriteLine("Введите число m: ");
// int m = TrueN();
// Console.WriteLine("Введите число n: ");
// int n = TrueN();
// Console.WriteLine();

// int[,] array = new int[m, n];
// FillAndPrintArray(array);
// Console.WriteLine();

// Console.WriteLine("Введите индекс строки: ");
// int indOne = TrueN();
// Console.WriteLine("Введите индекс столбца: ");
// int indTwo = TrueN();
// Console.WriteLine();
// FindElement(array, indOne, indTwo);

// Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое в каждом столбце.

Console.Clear();

int TrueN()
{
    bool BoolN = Int32.TryParse(Console.ReadLine(), out int N);
    while (BoolN == false)
    {
        Console.WriteLine("Вы ввели то, что не является числом. Попробуйте заново: ");
        BoolN = Int32.TryParse(Console.ReadLine(), out N);
    }
    return N;
}

void FillAndPrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] numbers)
{
    double[] ArithMean = new double[numbers.GetLength(1)];
    for (int l = 0; l < numbers.GetLength(1); l++)
    {
        double sum = 0;
        for (int k = 0; k < numbers.GetLength(0); k++) sum += numbers[k, l];
        ArithMean[l] = sum / ArithMean.Length;
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", ArithMean)}");
}

Console.WriteLine("Введите число m: ");
int m = TrueN();
Console.WriteLine("Введите число n: ");
int n = TrueN();
Console.WriteLine();

int[,] array = new int[m, n];
FillAndPrintArray(array);
Console.WriteLine();
ArithmeticMean(array);