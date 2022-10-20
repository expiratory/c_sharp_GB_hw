// Задача 17 Напишите программу, которая принимает на вход координаты точки (X и Y)
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// int GetQuarterFromCoordinate(int userX, int userY)
// {
//     int quarter = 0;
//     if (userX > 0 && userY >0)
//     {
//         quarter = 1;
//     }
//     else if (userX < 0 && userY > 0)
//     {
//         quarter = 2;
//     }
//     else if (userX < 0 && userY < 0)
//     {
//         quarter = 3;
//     }
//     else if (userX > 0 && userY < 0)
//     {
//         quarter = 4;
//     }
//     return quarter;
// }

// Console.WriteLine("Введите координату X: ");
// int userX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y: ");
// int userY = Convert.ToInt32(Console.ReadLine());

// int quarter = GetQuarterFromCoordinate(userX, userY);
// if (quarter != 0)
// {
//     Console.WriteLine($"Точка с координатами [{userX}:{userY}] находится в {quarter} четверти");
// }
// else
// {
//     Console.ForegroundColor = ConsoleColor.DarkRed;
//     Console.WriteLine($"Точка с координатами [{userX}:{userY}] находится на одной из осей");
//     Console.ResetColor();
// }

// Задача 18 Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
// Console.WriteLine("Введите номер четверти: ");
// int quarter = Convert.ToInt32(Console.ReadLine());

// if(quarter == 1)
// {
//     Console.WriteLine("x > 0, y > 0");
// }
// else if(quarter == 2)
// {
//     Console.WriteLine("x < 0, y > 0");
// }
// else if(quarter == 3)
// {
//     Console.WriteLine("x < 0, y < 0");
// }
// else if(quarter == 4)
// {
//     Console.WriteLine("x > 0, y < 0");
// }
// else
// {
//     Console.WriteLine("Такой четверти не существует");
// }

// Задача 21: Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 2D пространстве.
// Console.WriteLine("Введите координату X первой точки: ");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y первой точки: ");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату X второй точки: ");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y второй точки: ");
// int by = Convert.ToInt32(Console.ReadLine());

// double distance(int ax, int ay, int bx, int by)
// {
//     double result = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
//     return result;
// }

// double lenght = distance(ax, ay, bx, by);
// lenght = Math.Round(lenght, 3);
// Console.WriteLine($"Расстояние между точками с заданными координатами равно {lenght}");

// Задача 22: Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.
// первый вариант | не знаю зачемм через массив, но пусть будет =)

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] SqrtArray = new int[number];

void FillSqrtArray(int[] array)
{
    int count = 1;
    int index = 0;
    int size = array.Length;
    while(count <= size)
    {
        int sqrt = (int)Math.Pow(count, 2);
        array[index] = sqrt;
        index++;
        count++;
    }
}
void PrintSqrtArray(int[] collection)
{
    int volume = collection.Length;
    int position = 0;
    while(position < (volume-1))
    {
        Console.Write($"{collection[position]}, ");
        position++;
    }
    if (position == (volume-1))
    {
        Console.Write(collection[position]);
    }
}

FillSqrtArray(SqrtArray);
PrintSqrtArray(SqrtArray);

// второй вариант
// Console.WriteLine("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int square = 0;
// while(count < number)
// {
//     square = (int)Math.Pow(count, 2);
//     Console.Write($"{square}, ");
//     count++;
// }
// if(count == number)
// {
//     square = (int)Math.Pow(count, 2);
//     Console.Write($"{square}");
// }
// else
// {
//     Console.WriteLine("Введите натуральное число");
// }