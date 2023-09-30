using System.Collections.Generic;
using System;

delegate void DisplayMessage(string message);

class Program
{
    static void Main()
    {
        DisplayMessage showMessage = ShowMessageInConsole;

        showMessage("Це текстове повідомлення в консолі.");
        showMessage("Ще одне повідомлення.");

        showMessage = ShowMessageInMessageBox;
        showMessage("Це текстове повідомлення у вікні MessageBox.");
    }

    static void ShowMessageInConsole(string message)
    {
        Console.WriteLine("Повідомлення в консолі: " + message);
    }

    static void ShowMessageInMessageBox(string message)
    {
        System.Windows.Forms.MessageBox.Show("MessageBox: " + message);
    }
}


delegate void DisplayMessage(string message);

class Program2
{
    static void Main()
    {
        DisplayMessage showMessage = ShowMessageInConsole;

        showMessage("Це текстове повідомлення в консолі.");
        showMessage("Ще одне повідомлення.");

        showMessage = ShowMessageInMessageBox;
        showMessage("Це текстове повідомлення у вікні MessageBox.");
    }

    static void ShowMessageInConsole(string message)
    {
        Console.WriteLine("Повідомлення в консолі: " + message);
    }

    static void ShowMessageInMessageBox(string message)
    {
        System.Windows.Forms.MessageBox.Show("MessageBox: " + message);
    }
}

delegate bool NumberCheck(int number);
delegate int ArithmeticOperation(int num1, int num2);

class Program3
{
    static void Main()
    {
        List<int> numbers = new List<int> { 2, 5, 10, 15, 7 };

        Predicate<int> isEven = IsEven;
        Predicate<int> isOdd = IsOdd;
        Predicate<int> isPrime = IsPrime;
        Predicate<int> isFibonacci = IsFibonacci;

        foreach (var number in numbers)
        {
            Console.WriteLine($"{number} - парне: {isEven(number)}, непарне: {isOdd(number)}, просте: {isPrime(number)}, число Фібоначчі: {isFibonacci(number)}");
        }

        ArithmeticOperation add = (num1, num2) => num1 + num2;
        ArithmeticOperation subtract = (num1, num2) => num1 - num2;
        ArithmeticOperation multiply = (num1, num2) => num1 * num2;

        int num1 = 10;
        int num2 = 5;

        Console.WriteLine($"Додавання: {num1} + {num2} = {add(num1, num2)}");
        Console.WriteLine($"Віднімання: {num1} - {num2} = {subtract(num1, num2)}");
        Console.WriteLine($"Множення: {num1} * {num2} = {multiply(num1, num2)}");
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number <= 3)
            return true;
        if (number % 2 == 0 || number % 3 == 0)
            return false;
        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }
        return true;
    }

    static bool IsFibonacci(int number)
    {
        int a = 0;
        int b = 1;
        while (a < number)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a == number;
    }
}
