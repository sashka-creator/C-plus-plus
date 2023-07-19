using System;

public interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

public class Array : ICalc
{
    private int[] data;

    public Array(int[] arr)
    {
        data = arr;
    }

    public int Less(int valueToCompare)
    {
        int count = 0;
        foreach (var item in data)
        {
            if (item < valueToCompare)
                count++;
        }
        return count;
    }

    public int Greater(int valueToCompare)
    {
        int count = 0;
        foreach (var item in data)
        {
            if (item > valueToCompare)
                count++;
        }
        return count;
    }
}

public class Program
{
    public static void Main()
    {
        int[] dataArray = { 10, 15, 20, 25, 30 };
        Array array = new Array(dataArray);

        int valueToCompare = 22;

        int lessCount = array.Less(valueToCompare);
        int greaterCount = array.Greater(valueToCompare);

        Console.WriteLine($"Number of elements less than {valueToCompare}: {lessCount}");
        Console.WriteLine($"Number of elements greater than {valueToCompare}: {greaterCount}");
    }
}

///

public interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}

public class Array : IOutput2
{
    private int[] data;

    public Array(int[] arr)
    {
        data = arr;
    }

    public void ShowEven()
    {
        Console.WriteLine("Even elements:");
        foreach (var item in data)
        {
            if (item % 2 == 0)
                Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        Console.WriteLine("Odd elements:");
        foreach (var item in data)
        {
            if (item % 2 != 0)
                Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        int[] dataArray = { 10, 15, 20, 25, 30 };
        Array array = new Array(dataArray);

        array.ShowEven();
        array.ShowOdd();
    }
}
