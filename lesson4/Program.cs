// Суммирует все числа от 1 до N
// Console.Clear();

// void SumOfNumbers(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= Math.Abs(num); i++)
//     {
//         sum = sum + i;
//     }
//     Console.WriteLine($"Сумма цифр от 1 до введенного числа равна {sum}");
// }

// Console.WriteLine("Введите число: ");
// Int32.TryParse(Console.ReadLine(), out int number);
// SumOfNumbers(number);

// Умножает все числа от 1 до N
// Console.Clear();

// void MultiplicationOfNumbers(int num)
// {
//     int mult = 1;
//     for (int i = 1; i <= Math.Abs(num); i++)
//     {
//         mult = mult * i;
//     }
//     Console.WriteLine($"Произведение цифр от 1 до введенного числа равна {mult}");
// }

// Console.WriteLine("Введите число: ");
// Int32.TryParse(Console.ReadLine(), out int number);
// MultiplicationOfNumbers(number);

// Заполняет массив из 8 значений случайными цифрами 0 или 1
Console.Clear();

int[] numbersArray = new int [8];

void FillArray01(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int result = new Random().Next(0,2);
        array[i] = result;
    }
}

void PrintArray(int [] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        if (index < (arr.Length - 1))
        {
            Console.Write($"{arr[index]}, ");
        }
        if (index == (arr.Length - 1))
        {
            Console.Write(arr[index]);
        }
    }
}

FillArray01(numbersArray);
PrintArray(numbersArray);