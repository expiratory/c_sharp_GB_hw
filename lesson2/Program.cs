// int number = new Random().Next(10, 100);
// Console.WriteLine(number);

// if (number/10 > number%10)
// {
//     Console.WriteLine(number/10);
// }
// else
// {
//     Console.WriteLine(number%10);
// }

// Программа, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// int number = new Random().Next(10, 1000);
// Console.WriteLine(number);
// int number1 = number/100;
// int number2 = number%10;
// int result = number1*10 + number2;
// Console.WriteLine(result);

// Программа принимает на вход два числа и выводит, является ли второе число кратным первому
// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int ostatok = number1%number2;

// if (ostatok == 0)
// {
//     Console.WriteLine($"Число {number2} кратно {number1}");
// }
// else
// {
//     Console.WriteLine($"Число {number2} не кратно {number1}, остаток {ostatok}");
// }

// Является ли одно число квадратом другого
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == Math.Pow(number2, 2) | number2 == Math.Pow(number1, 2))
{
    Console.WriteLine("Одно из чисел является квадратом другого");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}

// Делится ли число одновременно на 7 и на 23
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number%7 == 0 && number%23 == 0)
// {
//     Console.WriteLine($"Число {number} кратно одновременно 7 и 23");
// }
// else
// {
//     Console.WriteLine($"Число {number} не кратно одновременно 7 и 23");
// }