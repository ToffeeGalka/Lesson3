#region задание 1
using System;

Console.WriteLine("Введите номер месяца ввиде числа от 1 до 12:");
        string month = Console.ReadLine();
        switch (month)
        {
            case "1" or "2" or "12":
                Console.WriteLine("Пора года - ЗИМА");
                break;
            case "3" or "4" or "5":
                Console.WriteLine("Пора года - ВЕСНА");
                break;
            case "6" or "7" or "8":
                Console.WriteLine("Пора года - ЛЕТО");
                break;
            case "9" or "10" or "11":
                Console.WriteLine("Пора года - ОСЕНЬ");
                break;
            default:
                Console.WriteLine("Вы ввели неизветное значение!");
                break;
        }
#endregion 

#region задание 2
        Console.WriteLine("Введите номер месяца ввиде числа от 1 до 12:");
        int month1 = Convert.ToInt32(Console.ReadLine());
      

        if (month1 == 1 || month1 == 2 || month1 == 12)
        {
            Console.WriteLine("Пора года - ЗИМА");
        }
        else if (month1 == 3 || month1 == 4 || month1 == 5)
        {
            Console.WriteLine("Пора года - ВЕСНА");
        }
        else if (month1 == 6 || month1 == 7 || month1 == 8)
        {
            Console.WriteLine("Пора года - ЛЕТО");
        }
        else if (month1 == 9 || month1 == 10 || month1 == 11)
        {
            Console.WriteLine("Пора года - ОСЕНЬ");
        }
        else 
        {
            Console.WriteLine("Вы ввели неизветное значение!");
        }
#endregion 

#region задание 3
        Console.WriteLine("Введите целое число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Вы ввели четное число");
        }
        else
        {
            Console.WriteLine("Вы ввели нечетное число");
        }
#endregion


#region задание 4
        Console.WriteLine("Введите температуру за окном:");
        int t = Convert.ToInt32(Console.ReadLine());

        if (t >= -5)
        {
            Console.WriteLine("Тепло");
        }
        else if (t<-5 && t>=-20)
        {
            Console.WriteLine("Нормально");
        }
        else
        {
            Console.WriteLine("Холодно");
        }
#endregion
#region задание 5
Console.WriteLine("Введите номер радуги от 1 до 7:");
string color = Console.ReadLine();
switch (color)
{
    case "1":
        Console.WriteLine("Красный");
        break;
    case "2":
        Console.WriteLine("Оранжевый");
        break;
    case "3":
        Console.WriteLine("Желтый");
        break;
    case "4" :
        Console.WriteLine("Зеленый");
        break;
    case "5":
        Console.WriteLine("Голубой");
        break;
    case "6":
        Console.WriteLine("Синий");
        break;
    case "7":
        Console.WriteLine("Фиолетовый");
        break;
    default:
        Console.WriteLine("Вы ввели неизветное значение!");
        break;
}
#endregion







