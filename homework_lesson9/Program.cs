// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.

// Console.Clear();

// void PrintNumbers(int n)
// {
//     if (n > 0)
//     {
//         Console.WriteLine(n);
//         PrintNumbers(n - 1);
//     }
// }

// int number = 10;
// PrintNumbers(number);

// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Clear();

// void SumOfNumbers(int sum, int m, int n)
// {
//     if (m > n)
//     {
//         sum += m;
//         SumOfNumbers(sum, m - 1, n);
//     }
//     if (n > m)
//     {
//         sum += n;
//         SumOfNumbers(sum, m, n - 1);
//     }
//     if (m == n) Console.WriteLine(sum += m);
// }

// int numM = 10;
// int numN = 15;
// int sumNum = 0;
// SumOfNumbers(sumNum, numM, numN);

// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

int Akkerman(int akk, int m, int n)
{
    if (m == 0) akk = n + 1;
    else if (m > 0 && n == 0) akk = Akkerman(akk, m - 1, 1);
    else if (m > 0 && n > 0) akk = Akkerman(akk, m - 1, Akkerman(akk, m, n - 1));
    return akk;
}

int numM = 3;
int numN = 2;
int Akker = 0;
Akker = Akkerman(Akker, numM, numN);
Console.WriteLine(Akker);