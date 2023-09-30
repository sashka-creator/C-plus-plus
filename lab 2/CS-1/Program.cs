using System;
using System.Collections.Generic;
using System;

using System;

interface IOutput
{
    void Show();
    void Show(string info);
}

class Array : IOutput
{
    private int[] data;

    public Array(int[] dataArray)
    {
        data = dataArray;
    }

    public void Show()
    {
        Console.WriteLine("Елементи масиву:");
        foreach (var item in data)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public void Show(string info)
    {
        Console.WriteLine(info);
        Show();
    }
}

class Program1
{
    static void Main()
    {
        int[] dataArray = { 1, 2, 3, 4, 5 };
        Array array = new Array(dataArray);

        array.Show("Масив даних:");
    }
}

// Створення інтерфейсу IMath
interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}

// Клас Array, який реалізує інтерфейс IMath
class Array : IMath
{
    private int[] data;

    public Array(int[] dataArray)
    {
        data = dataArray;
    }

    public int Max()
    {
        return data.Max();
    }

    public int Min()
    {
        return data.Min();
    }

    public float Avg()
    {
        return data.Average();
    }

    public bool Search(int valueToSearch)
    {
        return data.Contains(valueToSearch);
    }
}

class Program2
{
    static void Main()
    {
        int[] dataArray = { 1, 2, 3, 4, 5 };
        Array array = new Array(dataArray);

        Console.WriteLine($"Максимум: {array.Max()}");
        Console.WriteLine($"Мінімум: {array.Min()}");
        Console.WriteLine($"Середнє: {array.Avg()}");
        Console.WriteLine($"Пошук 3: {array.Search(3)}");
        Console.WriteLine($"Пошук 6: {array.Search(6)}");
    }
}
