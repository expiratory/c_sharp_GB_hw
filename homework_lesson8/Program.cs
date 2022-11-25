// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой
// строки двумерного массива.

// Console.Clear();

// int[,] FillArray()
// {
//     int m = 4;
//     int n = 4;
//     int[,] arr = new int[m, n];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++) arr[i, j] = new Random().Next(1, 10);
//     }
//     return arr;
// }

// void PrintArray(int[,] array)
// {
//     for (int k = 0; k < array.GetLength(0); k++)
//     {
//         for (int l = 0; l < array.GetLength(1); l++) Console.Write($"{array[k, l]} ");
//         Console.WriteLine();
//     }
// }

// void FromMaxToMin(int[,] newArray)
// {
//     for (int g = 0; g < newArray.GetLength(0); g++)
//     {
//         for (int h = 0; h < newArray.GetLength(1); h++)
//         {
//             for (int hPlus = h + 1; hPlus < newArray.GetLength(1); hPlus++)
//             {
//                 if (newArray[g, h] < newArray[g, hPlus])
//                 {
//                     int temp = newArray[g, h];
//                     newArray[g, h] = newArray[g, hPlus];
//                     newArray[g, hPlus] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] newestArray = FillArray();
// PrintArray(newestArray);
// Console.WriteLine();
// FromMaxToMin(newestArray);
// PrintArray(newestArray);

// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

// Console.Clear();

// int[,] FillArray()
// {
//     int m = 4;
//     int n = 4;
//     int[,] arr = new int[m, n];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++) arr[i, j] = new Random().Next(1, 10);
//     }
//     return arr;
// }

// void PrintArray(int[,] array)
// {
//     for (int k = 0; k < array.GetLength(0); k++)
//     {
//         for (int l = 0; l < array.GetLength(1); l++) Console.Write($"{array[k, l]} ");
//         Console.WriteLine();
//     }
// }

// void MaxSumLine(int[,] newArray)
// {
//     int[] sumArray = new int[newArray.GetLength(0)];
//     for (int h = 0; h < newArray.GetLength(0); h++)
//     {
//         int sum = 0;
//         for (int g = 0; g < newArray.GetLength(1); g++) sum += newArray[h, g];
//         sumArray[h] = sum;
//     }
//     int minLine = 0;
//     int min = sumArray[0];
//     for (int count = 0; count < sumArray.Length; count++)
//     {
//         if (sumArray[count] < min)
//         {
//             min = sumArray[count];
//             minLine = count;
//         }
//     }
//     Console.WriteLine($"Сумма элементов каждой отдельной строки по порядку: {String.Join(",", sumArray)}");
//     Console.WriteLine($"Номер строки с минимальной суммой ее элементов равен {minLine + 1}");
// }

// int[,] newestArray = FillArray();
// PrintArray(newestArray);
// Console.WriteLine();
// MaxSumLine(newestArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.

// Console.Clear();

// int[,] FillMatrix()
// {
//     int m = 2;
//     int n = 2;
//     int[,] arr = new int[m, n];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++) arr[i, j] = new Random().Next(1, 10);
//     }
//     return arr;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int k = 0; k < array.GetLength(0); k++)
//     {
//         for (int l = 0; l < array.GetLength(1); l++) Console.Write($"{array[k, l]} ");
//         Console.WriteLine();
//     }
// }

// void MatrixMultiplication(int[,] arr1, int[,] arr2)
// {
//     int[,] multiArray = new int[arr1.GetLength(0), arr2.GetLength(1)];
//     for (int g = 0; g < arr1.GetLength(0); g++)
//     {
//         for (int h = 0; h < arr2.GetLength(1); h++)
//         {
//             for (int o = 0; o < arr1.GetLength(1); o++) multiArray[g,h] += arr1[g,o] * arr2[o,h];
//         }
//     }
//     PrintMatrix(multiArray);
// }

// int[,] matrix1 = FillMatrix();
// int[,] matrix2 = FillMatrix();
// PrintMatrix(matrix1);
// Console.WriteLine();
// PrintMatrix(matrix2);
// Console.WriteLine();
// MatrixMultiplication(matrix1, matrix2);

// Задача 60: Сформируйте трёхмерный массив из
// неповторяющихся двузначных чисел. Напишите программу, которая
// будет построчно выводить массив, добавляя индексы каждого элемента.

// Console.Clear();

// bool CheckNumber(int[,,] newArray, int number)
// {
//     for (int iOne = 0; iOne < newArray.GetLength(0); iOne++)
//     {
//         for (int iTwo = 0; iTwo < newArray.GetLength(1); iTwo++)
//         {
//             for (int iThree = 0; iThree < newArray.GetLength(2); iThree++)
//             {
//                 if (newArray[iOne, iTwo, iThree] == number) return true;
//             }
//         }
//     }
//     return false;
// }

// int[,,] FillArray()
// {
//     int m = 2;
//     int n = 2;
//     int o = 2;
//     int[,,] arr = new int[m, n, o];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int g = 0; g < arr.GetLength(2); g++)
//             {
//                 int num = new Random().Next(10, 100);
//                 while (CheckNumber(arr, num) == true) num = new Random().Next(10, 100);
//                 arr[i, j, g] = num;
//             }
//         }
//     }
//     return arr;
// }

// void PrintArray(int[,,] array)
// {
//     for (int count = 0; count < array.GetLength(2); count++)
//     {
//         for (int k = 0; k < array.GetLength(0); k++)
//         {
//             for (int l = 0; l < array.GetLength(1); l++)
//             {
//                 for (int h = 0; h < array.GetLength(2); h++)
//                 {
//                     if (count == h) Console.Write($"{array[k, l, h]} {(k, l, h)} ");
//                 }
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// int[,,] newestArray = FillArray();
// PrintArray(newestArray);

// Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

Console.Clear();

void FillArray(int[,] arr)
{
    int m = 0;
    int n = 0;
    
    for (int number = 1; number <= 16; number++)
    {
        if (number >= 2 && number <= 4) n += 1;
        
        if (number >= 5 && number <= 7) m += 1;
        
        if (number >= 8 && number <= 10) n -= 1;
        
        if (number >= 11 && number <= 12) m -= 1;
        
        if (number >= 13 && number <= 14) n += 1;

        if (number == 15) m += 1;

        if (number == 16) n -= 1;

        arr[m,n] = number;
    }
}

void PrintArray(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int l = 0; l < array.GetLength(1); l++) Console.Write($"{array[k, l],4}");
        Console.WriteLine();
    }
}

int g = 4;
int h = 4;
int[,] array = new int [g,h];
FillArray(array);
PrintArray(array);