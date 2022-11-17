// Задача 39: Напишите программу, которая перевернет одномерный массив

// Console.Clear();

// void FillRandomArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(1,11);
// }

// void reverseArray(int[] arr)
// {
//     int f = arr.Length - 1;
//     for (int j = 0; j < arr.Length/2; j++, f--)
//     {
//         int temp = arr[j];
//         arr[j] = arr[f];
//         arr[f] = temp;
//     }
// }

// int[] arrayForReverse = new int [10];
// FillRandomArray(arrayForReverse);
// Console.WriteLine($"[{String.Join(",", arrayForReverse)}]");
// reverseArray(arrayForReverse);
// Console.WriteLine($"[{String.Join(",", arrayForReverse)}]");

// Задача 40: Напишите программу, которая принимает
// на вход три числа и проверяет, может ли существовать
// треугольник со сторонами такой длины.

// Console.Clear();

// void CheckTriangle(int x, int y, int z)
// {
//     if (x < y + z && y < x + z && z < x + y)
//         Console.WriteLine("Такой треугольник может существовать");
//     else Console.WriteLine("Такой треугольник не может существовать");
// }

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

// Console.WriteLine("Введите длину первой стороны треугольника: ");
// int a = TrueN();
// Console.WriteLine("Введите длину второй стороны треугольника: ");
// int b = TrueN();
// Console.WriteLine("Введите длину третьей стороны треугольника: ");
// int c = TrueN();
// CheckTriangle(a, b, c);

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

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

void FromTenToTwo()
{
    Console.WriteLine("Введите десятичное число, которое вы хотите перевести в двоичное:");
    int number = TrueN();

    int grade = 1;
    for (int i = 2; i <= number; i *= 2) grade++;

    int[] numberTwo = new int[grade];
    int f = grade - 1;
    for (int j = 0; j < numberTwo.Length; j++)
    {
        numberTwo[f] = number % 2;
        number = number / 2;
        f--;
    }

    Console.WriteLine($"Двоичное представление введенного числа: {String.Join("", numberTwo)}");
}

FromTenToTwo();

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

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

// void fibonacci()
// {
//     Console.WriteLine("Введите желаемое количество чисел Фибоначчи: ");
//     int number = TrueN();
//     int[] fibArray = new int[number];
//     fibArray[0] = 0;
//     fibArray[1] = 1;
//     for (int i = 2; i < number; i++) fibArray[i] = fibArray[i-1] + fibArray[i-2];
//     Console.WriteLine($"Первые {number} чисел Фибоначчи: {String.Join(", ", fibArray)}");
// }

// fibonacci();

// Задача 45: Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования

// Console.Clear();

// int[] GetRandomArray()
// {
//     int[] array = new int [10];
//     for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(1,11);
//     return array;
// }

// int[] CopyArray(int[] arr)
// {
//     int[] newArray = new int [arr.Length];
//     for (int j = 0; j < arr.Length; j++) newArray[j] = arr[j];
//     return newArray;
// }

// int[] arrayForCopy = GetRandomArray();
// Console.WriteLine($"[{String.Join(", ", arrayForCopy)}]");
// int[] copiedArray = CopyArray(arrayForCopy);
// Console.WriteLine($"[{String.Join(", ", copiedArray)}]");