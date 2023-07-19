using System;

struct Vector3D
{
    public double X;
    public double Y;
    public double Z;

    public Vector3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public Vector3D MultiplyByScalar(double scalar)
    {
        return new Vector3D(X * scalar, Y * scalar, Z * scalar);
    }

    public Vector3D Add(Vector3D other)
    {
        return new Vector3D(X + other.X, Y + other.Y, Z + other.Z);
    }

    public Vector3D Subtract(Vector3D other)
    {
        return new Vector3D(X - other.X, Y - other.Y, Z - other.Z);
    }
}

class Program
{
    static void Main()
    {
        Vector3D vector1 = new Vector3D(1.0, 2.0, 3.0);
        Vector3D vector2 = new Vector3D(2.0, 3.0, 4.0);

        double scalar = 2.0;
        Vector3D result = vector1.MultiplyByScalar(scalar);
        Console.WriteLine($"Результат множення вектора на число: ({result.X}, {result.Y}, {result.Z})");

        Vector3D sum = vector1.Add(vector2);
        Console.WriteLine($"Результат додавання векторів: ({sum.X}, {sum.Y}, {sum.Z})");

        Vector3D difference = vector1.Subtract(vector2);
        Console.WriteLine($"Результат віднімання векторів: ({difference.X}, {difference.Y}, {difference.Z})");
    }
}

//

struct DecimalNumber
{
    private double value;

    public DecimalNumber(double value)
    {
        this.value = value;
    }

    public string ToBinary()
    {
        long intValue = (long)value;
        return Convert.ToString(intValue, 2);
    }

    public string ToOctal()
    {
        long intValue = (long)value;
        return Convert.ToString(intValue, 8);
    }

    public string ToHexadecimal()
    {
        long intValue = (long)value;
        return Convert.ToString(intValue, 16);
    }
}

class Program
{
    static void Main()
    {
        double decimalValue = 255.75;
        DecimalNumber number = new DecimalNumber(decimalValue);

        string binary = number.ToBinary();
        Console.WriteLine($"Двійкове представлення числа: {binary}");

        string octal = number.ToOctal();
        Console.WriteLine($"Вісімкове представлення числа: {octal}");

        string hexadecimal = number.ToHexadecimal();
        Console.WriteLine($"Шістнадцяткове представлення числа: {hexadecimal}");
    }
}
