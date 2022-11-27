// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке
// от 1 до N

// Console.Clear();

// void PrintNumbers(int n, int i)
// {

//     if (i <= n)
//     {
//         Console.WriteLine(i);
//         PrintNumbers(n, i + 1);
//     }
// }

// int index = 1;
// int number = 10;
// PrintNumbers(number, index);

// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N

// Console.Clear();

// void AllNumbers(int m, int n)
// {
//     if (m > n)
//     {
//         Console.WriteLine(n);
//         AllNumbers(m, n + 1);
//     }
//     if (n > m)
//     {
//         Console.WriteLine(m);
//         AllNumbers(m + 1, n);
//     }
//     if (m == n) Console.WriteLine(m);
// }

// int numM = 10;
// int numN = 15;
// AllNumbers(numM, numN);

// Задача 67: Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр

// Console.Clear();

// void SumOfNumbers(int sum, int m)
// {
//     if (m > 9)
//     {
//         sum += m%10;
//         m = m/10;
//         SumOfNumbers(sum, m);
//     }
//     else Console.WriteLine(sum += m);
// }

// int numM = 12345;
// int sumNum = 0;
// SumOfNumbers(sumNum, numM);

// Задача 69: напишите программу, которая на вход принимает
// два числа A и B, и возводит число A в целую степень B
// с помощью рекурсии

int TrueN ()
{
    bool BoolN = Int32.TryParse(Console.ReadLine(), out int N);
    while (BoolN == false)
    {
        Console.WriteLine("Вы ввели то, что не является числом. Попробуйте заново: ");
        BoolN = Int32.TryParse(Console.ReadLine(), out N);
    }
    return N;
}

Console.Clear();

void LooksLikeMathPow(double grade, int m, int n)
{
    if (n > 1)
    {
        grade *= m;
        LooksLikeMathPow(grade, m, n - 1);
    }
    if (n < -1)
    {
        grade /= m;
        LooksLikeMathPow(grade, m, n + 1);
    }
    else if (n == -1) Console.WriteLine(grade /= m);
    else if (n == 1) Console.WriteLine(grade *= m);
    else if (n == 0) Console.WriteLine(1);
}

Console.WriteLine("Введите значение A: ");
int numA = TrueN();
Console.WriteLine("Введите значение B: ");
int numB = TrueN();
double gradation = 1;
LooksLikeMathPow(gradation, numA, numB);