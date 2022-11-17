// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле:
// Amn = m+n. Выведите полученный массив на экран.

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
//             arr[i,j] = i + j;
//             Console.Write($"{arr[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите число m: ");
// int m = TrueN();
// Console.WriteLine("Введите число n: ");
// int n = TrueN();
// Console.WriteLine();

// int[,] array = new int[m, n];
// FillAndPrintArray(array);

// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса четные, и замените эти элементы на их квадраты.

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

// void ChangeEvenForSquareAndPrint(int[,] numbers)
// {
//     for (int g = 0; g < numbers.GetLength(0); g++)
//     {
//         for (int k = 0; k < numbers.GetLength(1); k++)
//         {
//             if (g % 2 == 0 && k % 2 == 0) numbers[g, k] = (int)Math.Pow(numbers[g, k], 2);
//             Console.Write($"{numbers[g, k]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите число m: ");
// int m = TrueN();
// Console.WriteLine("Введите число n: ");
// int n = TrueN();
// Console.WriteLine();

// int[,] array = new int[m, n];
// FillAndPrintArray(array);
// Console.WriteLine();
// ChangeEvenForSquareAndPrint(array);

// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (0,0); (1,1) и т.д.

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

void SumByDiagonal(int[,] numbers)
{
    int sum = 0;
    for (int g = 0; g < numbers.GetLength(0); g++)
    {
        for (int k = 0; k < numbers.GetLength(1); k++)
        {
            if (g == k) sum += numbers[g, k];
        }
    }
    Console.WriteLine($"Сумма элементов по диагонали равна {sum}");
}

Console.WriteLine("Введите число m: ");
int m = TrueN();
Console.WriteLine("Введите число n: ");
int n = TrueN();
Console.WriteLine();

int[,] array = new int[m, n];
FillAndPrintArray(array);
Console.WriteLine();
SumByDiagonal(array);