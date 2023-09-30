using System;
using System.Collections.Generic;
using System.IO;

class Program1
{
    static void Main()
    {
        List<int> numbers = GenerateNumbers(100);
        List<int> primeNumbers = FindPrimes(numbers);
        List<int> fibonacciNumbers = FindFibonacci(numbers);

        SaveNumbersToFile("prime_numbers.txt", primeNumbers);
        SaveNumbersToFile("fibonacci_numbers.txt", fibonacciNumbers);

        Console.WriteLine("Статистика:");
        Console.WriteLine($"Згенеровано чисел: {numbers.Count}");
        Console.WriteLine($"Простих чисел: {primeNumbers.Count}");
        Console.WriteLine($"Чисел Фібоначчі: {fibonacciNumbers.Count}");
    }

    static List<int> GenerateNumbers(int count)
    {
        List<int> numbers = new List<int>();
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            numbers.Add(random.Next(1, 1000));
        }

        return numbers;
    }

    static List<int> FindPrimes(List<int> numbers)
    {
        List<int> primes = new List<int>();

        foreach (int number in numbers)
        {
            if (IsPrime(number))
            {
                primes.Add(number);
            }
        }

        return primes;
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

    static List<int> FindFibonacci(List<int> numbers)
    {
        List<int> fibonacciNumbers = new List<int>();
        foreach (int number in numbers)
        {
            if (IsFibonacci(number))
            {
                fibonacciNumbers.Add(number);
            }
        }
        return fibonacciNumbers;
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

    static void SaveNumbersToFile(string fileName, List<int> numbers)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (int number in numbers)
            {
                writer.WriteLine(number);
            }
        }
    }
}

class Program2
{
    static void Main()
    {
        Console.Write("Введіть шлях до файлу: ");
        string filePath = Console.ReadLine();

        Console.Write("Введіть слово для пошуку: ");
        string searchWord = Console.ReadLine();

        Console.Write("Введіть слово для заміни: ");
        string replaceWord = Console.ReadLine();

        string fileContents = ReadFileContents(filePath);
        string modifiedContents = ReplaceWord(fileContents, searchWord, replaceWord);

        WriteToFile(filePath, modifiedContents);

        Console.WriteLine("Заміна завершена.");
    }

    static string ReadFileContents(string filePath)
    {
        try
        {
            return File.ReadAllText(filePath);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не знайдено.");
            Environment.Exit(1);
            return null;
        }
        catch (IOException)
        {
            Console.WriteLine("Помилка при читанні файлу.");
            Environment.Exit(1);
            return null;
        }
    }

    static string ReplaceWord(string text, string searchWord, string replaceWord)
    {
        return text.Replace(searchWord, replaceWord);
    }

    static void WriteToFile(string filePath, string content)
    {
        try
        {
            File.WriteAllText(filePath, content);
        }
        catch (IOException)
        {
            Console.WriteLine("Помилка при записі у файл.");
            Environment.Exit(1);
        }
    }
}

class Program3
{
    static void Main()
    {
        Console.Write("Введіть шлях до файлу з текстом: ");
        string textFilePath = Console.ReadLine();

        Console.Write("Введіть шлях до файлу зі словами для модерації: ");
        string moderationFilePath = Console.ReadLine();

        string text = ReadFileContents(textFilePath);
        string[] moderationWords = ReadModerationWords(moderationFilePath);

        string moderatedText = ModerateText(text, moderationWords);

        WriteToFile(textFilePath, moderatedText);

        Console.WriteLine("Модерація завершена.");
    }

    static string ReadFileContents(string filePath)
    {
        try
        {
            return File.ReadAllText(filePath);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не знайдено.");
            Environment.Exit(1);
            return null;
        }
        catch (IOException)
        {
            Console.WriteLine("Помилка при читанні файлу.");
            Environment.Exit(1);
            return null;
        }
    }

