using System.ComponentModel.Design;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        double a;
        double b;
        double result;
        char oper;
        while (true)
        {
            Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО:");
            if (!Double.TryParse(Console.ReadLine(), out a))
            { 
                Console.WriteLine("Ошибка ввода, введите чиcло!"); 
                Main(args);
            }

            while (true)
            {
                while (true)
                {
                    Console.WriteLine("\n Вычитание: - \n Сложение: + \n Умножение: * \n Деление: / \n Процент от числа: % \n Квадратный корень числа: ! \n Результат: = \n ВВЕДИТЕ АРИФМЕТИЧЕСКУЮ ОПЕРАЦИЮ: ");
                    oper = Convert.ToChar(Console.ReadLine());
                    if (oper != '-' & oper != '+' & oper != '*' & oper != '/' & oper != '%' & oper != '!' & oper != '=')
                    {
                        Console.WriteLine("Ошибка ввода, введите правильно арифметический оператор!");
                    }
                    else
                    {
                        break;
                    }
                }

                if (oper != '=' & oper != '!')
                {
                    while (true)
                    {
                        Console.WriteLine("ВВЕДИТЕ СЛЕДУЮЩЕЕ ЧИСЛО:");
                        if (!Double.TryParse(Console.ReadLine(), out b))
                        {
                            Console.WriteLine("Ошибка ввода, введите чиcло!");
                        }
                        else 
                        {
                            break; 
                        }
                    }
                        //  b = Convert.ToDouble(Console.ReadLine());
                    if (oper == '-')
                    {
                        a = a - b;
                    }
                    else if (oper == '+')
                    {
                        a = a + b;
                    }
                    else if (oper == '/')
                    {
                        a = a / b;
                        if (b == 0)
                        {
                            Console.WriteLine("Деление на 0 невозможно");
                            break;
                        }
                    }
                    else if (oper == '*')
                    {
                        a = a * b;
                    }
                    else if (oper == '%')
                    {
                        a = a / 100 * b;
                    }
                }
                else if (oper == '!')
                {
                    if (a > 0)
                    {
                        a = Math.Sqrt(a);
                    }
                    else
                    {
                        Console.WriteLine($"Из отрицательного числа {a} нельзя извлечь корень!");
                        break;
                    }
                }
                else if (oper == '=') 
                {
                    result = a;
                    Console.WriteLine("Результат:" + result);
                    break;
                }
            }
            Console.WriteLine("\n ПРОДОЛЖИМ? Y:");
            char Cancel = Convert.ToChar(Console.ReadLine());
            if (Cancel != 'Y') 
            {
                break;
            }
        }
    }
}