// Задача 10 - принимает трехзначное число на вход и на выходе показывает вторую цифру этого числа
// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// while (true)
// {
//     if (number > 99 && number < 1000)
//     {
//         int number1and2 = number/10;
//         int number2 = number1and2%10;
//         Console.WriteLine(number2);
//         break;
//     }
//     else
//     {
//         while (number <= 99 || number >= 1000)
//         {
//             Console.WriteLine("Введенное вами число не трехзначное, введите ТРЕХЗНАЧНОЕ число: ");
//             number = Convert.ToInt32(Console.ReadLine());
//             if (number > 99 && number < 1000)
//             {
//                 break;
            
//             }   
//         }
//     }
// }

// Задача 13 - выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int numberTo123(int chislo)
{
    while (chislo >= 1000)
        {
            chislo = chislo/10;
        }
    number = chislo;
    return number;
}

if (number > 99)
{
    while (true)
    {
        if (number > 99 && number < 1000)
        {
            int number3 = number%10;
            Console.WriteLine(number3);
            break;
        }
        else
        {
            numberTo123(number);
        }
    }
}
else
{
    Console.WriteLine("Третьей цифры нет");
}