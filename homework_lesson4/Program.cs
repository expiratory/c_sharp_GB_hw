// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B

// Console.Clear();

// void Exponentiation()
// {
//     Console.WriteLine("Введите число A: ");
//     bool successNumA = Int32.TryParse(Console.ReadLine(), out int numberA);

//     while (successNumA == false)
//     {
//         Console.WriteLine("То что вы ввели как число A - не является числом. Попробуйте заново.");
//         Console.WriteLine("Введите число A: ");
//         successNumA = Int32.TryParse(Console.ReadLine(), out numberA);
//     }

//     Console.WriteLine("Введите число B: ");
//     bool successNumB = Int32.TryParse(Console.ReadLine(), out int numberB);

//     while (successNumB == false)
//     {
//         Console.WriteLine("То что вы ввели как число B - не является числом. Попробуйте заново.");
//         Console.WriteLine("Введите число B: ");
//         successNumB = Int32.TryParse(Console.ReadLine(), out numberB);
//     }

//     if (successNumA == true && successNumB == true)
//     {
//         int expo = 1;
//         for (int i = 0; i < numberB; i++)
//         {
//             expo = expo * numberA;
//         }
//         Console.WriteLine($"Число {numberA} в степени {numberB} равняется {expo}");
//     }
// }

// Exponentiation();

// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

// Console.Clear();

// void DigitSum()
// {
//     Console.WriteLine("Введите число: ");
//     bool successNum = Int32.TryParse(Console.ReadLine(), out int number);
//     int sum = 0;
//     int reservedNumber = number;
//     while (successNum == false)
//     {
//         Console.WriteLine("То что вы ввели - не является числом. Попробуйте заново.");
//         Console.WriteLine("Введите число: ");
//         successNum = Int32.TryParse(Console.ReadLine(), out number);
//         reservedNumber = number;
//     }
//     if (successNum == true)
//     {
//         number = Math.Abs(number);
//         while (number > 9)
//         {
//             sum = sum + number%10;
//             number = number/10;
//         }
//         sum = sum + number;
//     }
//     Console.WriteLine($"Сумма цифр числа {reservedNumber} равна {sum}");
// }

// DigitSum();

// Задача 29: Напишите программу, которая задаёт массив
// из N элементов и выводит их на экран.

Console.Clear();

void FillAndPrintArray()
{
    Console.WriteLine("Введите количество элементов массива: ");
    bool successN = Int32.TryParse(Console.ReadLine(), out int N);
    while (successN == false || (successN == true && N <=0))
    {
        Console.WriteLine("То что вы ввели либо не является числом, либо меньше или равно нулю. Попробуйте заново.");
        Console.WriteLine("Введите количество элементов массива: ");
        successN = Int32.TryParse(Console.ReadLine(), out N);
    }
    if (successN == true && N > 0)
    {
            int[] array = new int [N];
            for (int i = 0; i < N; i++)
            {
                array[i] = new Random().Next(0,100);
            }
            Console.WriteLine($"[{String.Join(",", array)}]");
    }
}

FillAndPrintArray();