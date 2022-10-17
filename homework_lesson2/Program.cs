// Задача 10 - принимает трехзначное число на вход и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (number > 99 && number < 1000)
    {
        int number1and2 = number/10;
        int number2 = number1and2%10;
        Console.WriteLine(number2);
        break;
    }
    else
    {
        while (number <= 99 || number >= 1000)
        {
            Console.WriteLine("Введенное вами число не трехзначное, введите ТРЕХЗНАЧНОЕ число");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 99 && number < 1000)
            {
                break;
            
            }   
        }
    }
}