using System;

class Program1
{
    static void Main()
    {
        Console.WriteLine("It's easy to win forgiveness for being wrong;");
        Console.WriteLine("being right is what gets you into real trouble.");
        Console.WriteLine("Bjarne Stroustrup");
    }
}

class Program2
{
    static void Main()
    {
        Console.WriteLine("Введіть п'ять чисел:");

        double sum = 0;
        double max = double.MinValue;
        double min = double.MaxValue;
        double product = 1;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Число " + (i + 1) + ": ");
            double number = Convert.ToDouble(Console.ReadLine());

            sum += number;
            if (number > max)
                max = number;
            if (number < min)
                min = number;
            product *= number;
        }

        Console.WriteLine("Сума: " + sum);
        Console.WriteLine("Максимум: " + max);
        Console.WriteLine("Мінімум: " + min);
        Console.WriteLine("Добуток: " + product);
    }
}

class Program3
{
    static void Main()
    {
        Console.Write("Введіть шестизначне число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = (reversedNumber * 10) + digit;
            number /= 10;
        }

        Console.WriteLine("Результат: " + reversedNumber);
    }
}

class Program4
{
    static void Main()
    {
        Console.Write("Введіть початок діапазону: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть кінець діапазону: ");
        int end = Convert.ToInt32(Console.ReadLine());

        int first = 0;
        int second = 1;

        Console.Write("Числа Фібоначчі в заданому діапазоні: ");

        while (first <= end)
        {
            if (first >= start)
                Console.Write(first + " ");

            int next = first + second;
            first = second;
            second = next;
        }

        Console.WriteLine();
    }
}

