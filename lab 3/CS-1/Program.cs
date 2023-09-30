using System;
using System.Collections.Generic;

using System;

struct Fraction
{
    public int Numerator { get; private set; }
    public int Denominator { get; private set; }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Знаменник не може дорівнювати нулю.");

        Numerator = numerator;
        Denominator = denominator;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int commonDenominator = a.Denominator * b.Denominator;
        int newNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
        return new Fraction(newNumerator, commonDenominator);
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        int commonDenominator = a.Denominator * b.Denominator;
        int newNumerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
        return new Fraction(newNumerator, commonDenominator);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        int newNumerator = a.Numerator * b.Numerator;
        int newDenominator = a.Denominator * b.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        if (b.Numerator == 0)
            throw new DivideByZeroException("Ділення на нуль не допускається.");

        int newNumerator = a.Numerator * b.Denominator;
        int newDenominator = a.Denominator * b.Numerator;
        return new Fraction(newNumerator, newDenominator);
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}

class Program1
{
    static void Main()
    {
        Fraction fraction1 = new Fraction(1, 2);
        Fraction fraction2 = new Fraction(3, 4);

        Fraction sum = fraction1 + fraction2;
        Fraction difference = fraction1 - fraction2;
        Fraction product = fraction1 * fraction2;
        Fraction quotient = fraction1 / fraction2;

        Console.WriteLine($"Додавання: {fraction1} + {fraction2} = {sum}");
        Console.WriteLine($"Віднімання: {fraction1} - {fraction2} = {difference}");
        Console.WriteLine($"Множення: {fraction1} * {fraction2} = {product}");
        Console.WriteLine($"Ділення: {fraction1} / {fraction2} = {quotient}");
    }
}


struct ComplexNumber
{
    public double RealPart { get; private set; }
    public double ImaginaryPart { get; private set; }

    public ComplexNumber(double realPart, double imaginaryPart)
    {
        RealPart = realPart;
        ImaginaryPart = imaginaryPart;
    }

    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
        double realSum = a.RealPart + b.RealPart;
        double imaginarySum = a.ImaginaryPart + b.ImaginaryPart;
        return new ComplexNumber(realSum, imaginarySum);
    }

    public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
    {
        double realDifference = a.RealPart - b.RealPart;
        double imaginaryDifference = a.ImaginaryPart - b.ImaginaryPart;
        return new ComplexNumber(realDifference, imaginaryDifference);
    }

    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
    {
        double realProduct = (a.RealPart * b.RealPart) - (a.ImaginaryPart * b.ImaginaryPart);
        double imaginaryProduct = (a.RealPart * b.ImaginaryPart) + (a.ImaginaryPart * b.RealPart);
        return new ComplexNumber(realProduct, imaginaryProduct);
    }

    public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
    {
        if (b.RealPart == 0 && b.ImaginaryPart == 0)
            throw new DivideByZeroException("Ділення на нуль не допускається.");

        double denominator = (b.RealPart * b.RealPart) + (b.ImaginaryPart * b.ImaginaryPart);
        double realQuotient = ((a.RealPart * b.RealPart) + (a.ImaginaryPart * b.ImaginaryPart)) / denominator;
        double imaginaryQuotient = ((a.ImaginaryPart * b.RealPart) - (a.RealPart * b.ImaginaryPart)) / denominator;
        return new ComplexNumber(realQuotient, imaginaryQuotient);
    }

    public override string ToString()
    {
        return $"{RealPart} + {ImaginaryPart}i";
    }
}

class Program2
{
    static void Main()
    {
        ComplexNumber complex1 = new ComplexNumber(1, 2);
        ComplexNumber complex2 = new ComplexNumber(3, 4);

        ComplexNumber sum = complex1 + complex2;
        ComplexNumber difference = complex1 - complex2;
        ComplexNumber product = complex1 * complex2;
        ComplexNumber quotient = complex1 / complex2;

        Console.WriteLine($"Додавання: {complex1} + {complex2} = {sum}");
        Console.WriteLine($"Віднімання: {complex1} - {complex2} = {difference}");
        Console.WriteLine($"Множення: {complex1} * {complex2} = {product}");
        Console.WriteLine($"Ділення: {complex1} / {complex2} = {quotient}");
    }
}


