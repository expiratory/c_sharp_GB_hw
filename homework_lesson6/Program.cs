// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Clear();

// int TrueN ()
// {
//     bool BoolN = Int32.TryParse(Console.ReadLine(), out int N);
//     while (BoolN == false)
//     {
//         Console.WriteLine("Вы ввели то, что не является числом. Попробуйте заново: ");
//         BoolN = Int32.TryParse(Console.ReadLine(), out N);
//     }
//     return N;
// }

// int CountNumbersMoreThanZero (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++) if (array[i] > 0) count++;
//     return count;
// }

// void FillArrayWithUserAndCount()
// {
//     Console.WriteLine("Введите количество чисел, которое вы хотите ввести: ");
//     int m = TrueN();
//     int[] array = new int [m];
//     for (int j = 0; j < array.Length; j++)
//     {
//         Console.WriteLine("Введите число: ");
//         array[j] = TrueN();
//     }
//     Console.WriteLine($"Количество элементов больше нуля равно {CountNumbersMoreThanZero(array)}");
// }

// FillArrayWithUserAndCount();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

double TrueN ()
{
    bool BoolN = Double.TryParse(Console.ReadLine(), out double N);
    while (BoolN == false)
    {
        Console.WriteLine("Вы ввели то, что не является числом. Попробуйте заново: ");
        BoolN = Double.TryParse(Console.ReadLine(), out N);
    }
    return N;
}

void PointOfIntersection(double KK1, double BB1, double KK2, double BB2)
{
    if (KK1 == KK2 && BB1 != BB2) Console.WriteLine("Данные прямые параллельны и не пересекаются");
    else if (KK1 == KK2 && BB1 == BB2) Console.WriteLine("Данные прямые идентичны");
    else
    {
        double x = (BB2 - BB1)/(KK1-KK2);
        double y = KK1 * x + BB1;
        Console.WriteLine($"x = {x}, y = {y}");
    }
}

Console.WriteLine("Введите значение для k1: ");
double k1 = TrueN();
Console.WriteLine("Введите значение для b1: ");
double b1 = TrueN();
Console.WriteLine("Введите значение для k2: ");
double k2 = TrueN();
Console.WriteLine("Введите значение для b2: ");
double b2 = TrueN();

PointOfIntersection(k1,k2,b1,b2);