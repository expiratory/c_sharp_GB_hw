// Задача 2 (какое из двух чисел больше, а какое меньше)
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine("Число " + number1 + " больше, чем число " + number2);
}
else
{
    Console.WriteLine("Число " + number2 + " больше, чем число " + number1);
}

// Задача 4 (максимальное из трех чисел)
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if(number1 > max) max = number1;
if(number2 > max) max = number2;
if(number3 > max) max = number3;

Console.WriteLine("Максимальным числом из введенных является " + max);

// Задача 6 (является ли число четным)
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Это число четное");
}
else
{
    Console.WriteLine("Это число нечетное");
}

// Задача 8 (показать все четные числа от 1 до N)
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1)
{
    if(number == 1) Console.WriteLine("Четных чисел от 1 до введенного Вами числа нет");

    if(number % 2 == 0)
    {
        Console.WriteLine(number);
        while(number > 2)
        {
            number = number -2;
            Console.WriteLine(number);
        }   
    }
    else
    {
        number = number - 1;
        Console.WriteLine(number);
        while(number > 2)
        {
            number = number - 2;
            Console.WriteLine(number);
        }
    }       
}
else Console.WriteLine("Вы ввели ненатуральное число");