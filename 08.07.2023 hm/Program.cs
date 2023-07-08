using System;

class Program1
{
    static void Main()
    {
        Console.Write("Введіть число від 1 до 100: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 1 && number <= 100)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("Помилка: число не знаходиться в діапазоні від 1 до 100.");
        }
    }
}

class Program2
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        double value = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть відсоток: ");
        double percentage = Convert.ToDouble(Console.ReadLine());

        double result = (value * percentage) / 100;
        Console.WriteLine("Результат: " + result);
    }
}

class Program3
{
    static void Main()
    {
        Console.WriteLine("Введіть чотири цифри:");

        Console.Write("Перша цифра: ");
        int digit1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Друга цифра: ");
        int digit2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Третя цифра: ");
        int digit3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Четверта цифра: ");
        int digit4 = Convert.ToInt32(Console.ReadLine());

        int number = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;
        Console.WriteLine("Створене число: " + number);
    }
}

