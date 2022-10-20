// Задача 19 - принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// number = Math.Abs(number);

// if(number > 9999 && number < 100000)
// {
//     int number1 = number/10000;
//     int number2 = number/1000 - number1*10;
//     int number5 = number%10;
//     int number4 = (number%100 - number5)/10;
//     if(number1 == number5 && number2 == number4)
//     {
//         Console.WriteLine("Данное число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Данное число не является палиндромом");
//     }
// }   
// else
// {
//     Console.WriteLine("Вы ввели не пятизначное число");
// }

// Задача 21 - принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.WriteLine("Введите коордунату X первой точки: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коордунату Y первой точки: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коордунату Z первой точки: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коордунату X второй точки: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коордунату Y второй точки: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коордунату Z второй точки: ");
int bz = Convert.ToInt32(Console.ReadLine());

double distance(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double result = Math.Sqrt(Math.Pow((X2-X1), 2)+Math.Pow((Y2-Y1), 2)+Math.Pow((Z2-Z1), 2));
    return result;
}

double dist = distance(ax, ay, az, bx, by, bz);
dist = Math.Round(dist, 2);
Console.WriteLine($"Расстояние между указанными точками в 3D пространстве равняется {dist}");

// Задача 23 - принимает на вход число и выдает таблицу кубов от 1 до N
// Console.WriteLine("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int cube = 0;

// if(number >= 1)
//     while(count < number)
//     {
//         cube = (int)Math.Pow(count, 3);
//         Console.Write($"{cube}, ");
//         count++;
//     }
//     if(count == number)
//     {
//         cube = (int)Math.Pow(count, 3);
//         Console.Write(cube);
//     }
// else
// {
//     Console.WriteLine("Вы ввели не натуральное число");
// }