// Создает массив из 12 элементов, заполненных случайными числами от -9 до 9
//  и показывает сумму положительных и сумму отрицательных значений массива

// Console.Clear();

// void GetSumPlusAndMinusArray()
// {
//     int[] array = new int [12];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     int sumPlus = 0;
//     int sumMinus = 0;
//     for (int j = 0; j < array.Length; j++)
//     {
//         if (array[j] == 0) continue;
//         else if (array[j] > 0) sumPlus += array[j];
//         else sumMinus += array[j];
//     }
//     Console.WriteLine($"[{String.Join(",", array)}]");
//     Console.WriteLine($"Сумма положительных элементов массива равна {sumPlus}");
//     Console.WriteLine($"Сумма отрицательных элементов массива равна {sumMinus}");
// }

// GetSumPlusAndMinusArray();

// Задача 32 В массиве положительные элементы замените
// на соответствующие отрицательные и наоборот

// Console.Clear();

// void ArrayChange()
// {
//     int[] array = new int [10];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 11);
//     }
//     Console.WriteLine($"[{String.Join(",", array)}]");
//     for (int j = 0; j < array.Length; j++)
//     {
//         array[j] *= -1;
//     }
//     Console.WriteLine($"[{String.Join(",", array)}]");
// }

// ArrayChange();

// Задача 33 Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве

// Console.Clear();

// void FindArray()
// {
//     int[] array = new int [25];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-50,51);
//     }
//     Console.WriteLine($"[{String.Join(",", array)}]");
//     int find = new Random().Next(-50,51);
//     Console.WriteLine($"Искомое число = {find}");
//     bool finded = false;
//     for (int j = 0; j < array.Length; j++)
//     {
//         if (array[j] == find)
//         {
//             finded = true;
//             break;
//         }
//         else continue;
//     }
//     if (finded == true) Console.WriteLine("Искомое число есть в массиве");
//     else Console.WriteLine("Искомого числа нет в массиве");
// }

// FindArray();

// Задача 35 Задайте массив из 123 случайных чисел
// Найдите количество элементов на отрезке [10, 99]

// Console.Clear();

// void FindInArray1099()
// {
//     int[] array = new int [123];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100,100);
//     }
//     Console.WriteLine($"[{String.Join(",", array)}]");
//     int count1099 = 0;
//     for (int j = 0; j < array.Length; j++)
//     {
//         if (array[j] > 9 && array[j] < 100) count1099 += 1;
//         else continue;
//     }
//     Console.WriteLine($"Количество элементов массива в диапазоне от 10 до 99 равняется {count1099}");
// }

// FindInArray1099();

// Задача 37 Найдите произведение пар чисел
// (парой считается первый и последний, второй и предпоследний и тд)
// Результат запишите в новом массиве

Console.Clear();

void MultiplicateElementsOfArray()
{
    int[] array = new int [new Random().Next(10,20)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,11);
    }
    Console.WriteLine($"[{String.Join(",", array)}]");
    int j = array.Length -1;
    int g = 0;
    int[] arrayNew = new int [array.Length];
    for (g = 0; g < j; g++)
    {
        arrayNew[g] = array[g] * array[j];
        j--;
    }
    if (g == j)
    {
        arrayNew[g] = array[g];
        int[] arrayFinal = new int [g+1];
        for (g = 0; g < arrayFinal.Length; g++)
        {
            arrayFinal[g] = arrayNew[g];
        }
        Console.WriteLine($"[{String.Join(",", arrayFinal)}]");
    }
    else
    {
        int[] arrayFinal = new int [g];
        for (g = 0; g < arrayFinal.Length; g++)
        {
            arrayFinal[g] = arrayNew[g];
        }
        Console.WriteLine($"[{String.Join(",", arrayFinal)}]");
    }
}

MultiplicateElementsOfArray();