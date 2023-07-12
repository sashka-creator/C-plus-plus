using System;

namespace NumberGenerator
{
    namespace EvenNumbers
    {
        class EvenNumberGenerator
        {
            private int currentNumber = 0;

            public int GenerateNumber()
            {
                currentNumber += 2;
                return currentNumber;
            }
        }
    }

    namespace OddNumbers
    {
        class OddNumberGenerator
        {
            private int currentNumber = -1;

            public int GenerateNumber()
            {
                currentNumber += 2;
                return currentNumber;
            }
        }
    }

    namespace PrimeNumbers
    {
        class PrimeNumberGenerator
        {
            private int currentNumber = 2;

            public int GenerateNumber()
            {
                while (!IsPrime(currentNumber))
                {
                    currentNumber++;
                }

                int primeNumber = currentNumber;
                currentNumber++;
                return primeNumber;
            }

            private bool IsPrime(int number)
            {
                if (number < 2)
                    return false;

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        return false;
                }

                return true;
            }
        }
    }

    namespace FibonacciNumbers
    {
        class FibonacciNumberGenerator
        {
            private int previousNumber = 0;
            private int currentNumber = 1;

            public int GenerateNumber()
            {
                int fibonacciNumber = currentNumber;
                int nextNumber = previousNumber + currentNumber;
                previousNumber = currentNumber;
                currentNumber = nextNumber;
                return fibonacciNumber;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Приклад використання генераторів чисел

            Console.WriteLine("Even numbers:");
            EvenNumbers.EvenNumberGenerator evenGenerator = new EvenNumbers.EvenNumberGenerator();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(evenGenerator.GenerateNumber());
            }

            Console.WriteLine();

            Console.WriteLine("Odd numbers:");
            OddNumbers.OddNumberGenerator oddGenerator = new OddNumbers.OddNumberGenerator();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(oddGenerator.GenerateNumber());
            }

            Console.WriteLine();

            Console.WriteLine("Prime numbers:");
            PrimeNumbers.PrimeNumberGenerator primeGenerator = new PrimeNumbers.PrimeNumberGenerator();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(primeGenerator.GenerateNumber());
            }

            Console.WriteLine();

            Console.WriteLine("Fibonacci numbers:");
            FibonacciNumbers.FibonacciNumberGenerator fibonacciGenerator = new FibonacciNumbers.FibonacciNumberGenerator();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(fibonacciGenerator.GenerateNumber());
            }

            Console.ReadLine();
        }
    }
}

namespace GeometryShapes
{
    namespace Triangles
    {
        class Triangle
        {
            private double side1;
            private double side2;
            private double side3;

            public Triangle(double side1, double side2, double side3)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }

            public double CalculatePerimeter()
            {
                return side1 + side2 + side3;
            }

            public double CalculateArea()
            {
                double semiPerimeter = CalculatePerimeter() / 2;
                return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
            }
        }
    }

    namespace Rectangles
    {
        class Rectangle
        {
            private double length;
            private double width;

            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public double CalculatePerimeter()
            {
                return 2 * (length + width);
            }

            public double CalculateArea()
            {
                return length * width;
            }
        }
    }

    namespace Squares
    {
        class Square
        {
            private double side;

            public Square(double side)
            {
                this.side = side;
            }

            public double CalculatePerimeter()
            {
                return 4 * side;
            }

            public double CalculateArea()
            {
                return side * side;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Приклад використання класів геометричних фігур

            Triangles.Triangle triangle = new Triangles.Triangle(3, 4, 5);
            Console.WriteLine("Triangle:");
            Console.WriteLine("Perimeter: " + triangle.CalculatePerimeter());
            Console.WriteLine("Area: " + triangle.CalculateArea());

            Console.WriteLine();

            Rectangles.Rectangle rectangle = new Rectangles.Rectangle(4, 6);
            Console.WriteLine("Rectangle:");
            Console.WriteLine("Perimeter: " + rectangle.CalculatePerimeter());
            Console.WriteLine("Area: " + rectangle.CalculateArea());

            Console.WriteLine();

            Squares.Square square = new Squares.Square(5);
            Console.WriteLine("Square:");
            Console.WriteLine("Perimeter: " + square.CalculatePerimeter());
            Console.WriteLine("Area: " + square.CalculateArea());

            Console.ReadLine();
        }
    }
}
