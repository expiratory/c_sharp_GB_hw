// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива

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

// void ChangeRows(int[,] arrayForChange)
// {
//     for (int g = 0; g < 1; g++)
//     {
//         for (int h = 0; h < arrayForChange.GetLength(1); h++)
//         {
//             int temp = arrayForChange[g,h];
//             arrayForChange[g,h] = arrayForChange[arrayForChange.GetLength(0)-1, h];
//             arrayForChange[arrayForChange.GetLength(0)-1, h] = temp;
//         }
//     }
// }

// int[,] newArray = FillArray();
// PrintArray(newArray);
// Console.WriteLine();
// ChangeRows(newArray);
// PrintArray(newArray);

// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение
// для пользователя

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

// int[,] ChangeRowsToColumns(int[,] arrayForChange)
// {
//     int[,] arrayChanged = new int [arrayForChange.GetLength(0), arrayForChange.GetLength(1)];
//     for (int g = 0; g < arrayForChange.GetLength(1); g++)
//     {
//         for (int h = 0; h < arrayForChange.GetLength(0); h++)
//         {
//             arrayChanged[g,h] = arrayForChange[h, g];
//         }
//     }
//     return arrayChanged;
// }

// int[,] newArray = FillArray();
// PrintArray(newArray);
// Console.WriteLine();
// int[,] newestArray = ChangeRowsToColumns(newArray);
// PrintArray(newestArray);

// Задача 57: Составить частотный словарь элементов
// двумерного массива. Часточный словарь содержит информацию
// о том, сколько раз встречается элемент входных данных

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

// int Frequency(int[,] arrayToCount, int arrayElement)
// {
//     int freq = 0;
//     for (int g = 0; g < arrayToCount.GetLength(0); g++)
//     {
//         for (int h = 0; h < arrayToCount.GetLength(1); h++)
//         {
//             if (arrayToCount[g, h] == arrayElement) freq += 1;
//         }
//     }
//     return freq;
// }

// bool FindElement (int[] arrayToFind, int find)
// {
//     for (int o = 0; o < arrayToFind.Length; o++)
//     {
//         if (arrayToFind[o] == find) return true;
//     }
//     return false;
// }

// void FrequencyDictionary(int[,] freqArray)
// {
//     int count = 0;
//     int[] arrayToStore = new int [freqArray.GetLength(0)*freqArray.GetLength(1)];
//     for (int m = 0; m < freqArray.GetLength(0); m++)
//     {
//         for (int n = 0; n < freqArray.GetLength(1); n++)
//         {
//             if (FindElement(arrayToStore, freqArray[m,n]) == true) continue;
//             Console.WriteLine($"Частота встречаемости элемента {freqArray[m,n]} равняется {Frequency(freqArray, freqArray[m,n])}");
//             arrayToStore[count] = freqArray[m,n];
//             count++;            
//         }
//     }
// }

// int[,] newArray = FillArray();
// PrintArray(newArray);
// Console.WriteLine();
// FrequencyDictionary(newArray);

// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива

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

// int[] FindMin(int[,] arrayToFindMin)
// {
//     int[] index = new int[2];
//     int min = arrayToFindMin[0, 0];
//     int max = arrayToFindMin[0, 0];
//     for (int g = 0; g < arrayToFindMin.GetLength(0); g++)
//     {
//         for (int h = 0; h < arrayToFindMin.GetLength(1); h++)
//         {
//             if (arrayToFindMin[g, h] > max) max = arrayToFindMin[g, h];
//             if (arrayToFindMin[g, h] < min)
//             {
//                 min = arrayToFindMin[g, h];
//                 index[0] = g;
//                 index[1] = h;
//             }
//         }
//     }
//     return index;
// }

// int[,] ArrayDeletedRowColumn(int[,] arrayForDelete, int[] minimalInd)
// {
//     int mm = 0;
//     int nn = 0;
//     int[,] delArray = new int[arrayForDelete.GetLength(0) - 1, arrayForDelete.GetLength(1) - 1];
//     for (int m = 0; m < arrayForDelete.GetLength(0); m++)
//     {
//         if (m == minimalInd[0]) continue;
//         for (int n = 0; n < arrayForDelete.GetLength(1); n++)
//         {
//             if (n == minimalInd[1]) continue;
//             delArray[mm, nn] = arrayForDelete[m, n];
//             nn++;
//         }
//         nn = 0;
//         mm++;
//     }
//     return delArray;
// }

// int[,] newestArray = FillArray();
// PrintArray(newestArray);
// int[] minIndex = FindMin(newestArray);
// int[,] deletedArray = ArrayDeletedRowColumn(newestArray, minIndex);
// Console.WriteLine();
// PrintArray(deletedArray);

// Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треуглоника

