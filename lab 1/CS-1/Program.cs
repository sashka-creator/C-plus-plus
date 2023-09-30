using System;
using System.Collections.Generic;
using System;

class Human
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Human(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Speak()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

class Builder : Human
{
    public string ConstructionSkills { get; set; }

    public Builder(string name, int age, string constructionSkills)
        : base(name, age)
    {
        ConstructionSkills = constructionSkills;
    }

    public void Build()
    {
        Console.WriteLine($"{Name} is a builder with skills in {ConstructionSkills}.");
    }
}

class Sailor : Human
{
    public string ShipType { get; set; }

    public Sailor(string name, int age, string shipType)
        : base(name, age)
    {
        ShipType = shipType;
    }

    public void Sail()
    {
        Console.WriteLine($"{Name} is a sailor on a {ShipType}.");
    }
}

class Pilot : Human
{
    public string AircraftType { get; set; }

    public Pilot(string name, int age, string aircraftType)
        : base(name, age)
    {
        AircraftType = aircraftType;
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} is a pilot flying a {AircraftType}.");
    }
}

class Program1
{
    static void Main()
    {
        Builder builder = new Builder("John", 30, "Carpentry");
        Sailor sailor = new Sailor("Alice", 25, "Cargo Ship");
        Pilot pilot = new Pilot("Bob", 35, "Jet Plane");

        builder.Speak();
        builder.Build();

        sailor.Speak();
        sailor.Sail();

        pilot.Speak();
        pilot.Fly();
    }
}
class Passport
{
    public string FullName { get; set; }
    public string PassportNumber { get; set; }

    public Passport(string fullName, string passportNumber)
    {
        FullName = fullName;
        PassportNumber = passportNumber;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Passport Number: {PassportNumber}");
    }
}

class ForeignPassport : Passport
{
    public string VisaInfo { get; set; }
    public string ForeignPassportNumber { get; set; }

    public ForeignPassport(string fullName, string passportNumber, string visaInfo, string foreignPassportNumber)
        : base(fullName, passportNumber)
    {
        VisaInfo = visaInfo;
        ForeignPassportNumber = foreignPassportNumber;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Visa Information: {VisaInfo}");
        Console.WriteLine($"Foreign Passport Number: {ForeignPassportNumber}");
    }
}

class Program2
{
    static void Main()
    {
        Passport passport = new Passport("John Smith", "123456789");
        ForeignPassport foreignPassport = new ForeignPassport("Alice Johnson", "987654321", "Multiple entry visa", "FP12345");

        Console.WriteLine("Passport Information:");
        passport.DisplayInfo();

        Console.WriteLine("\nForeign Passport Information:");
        foreignPassport.DisplayInfo();
    }
}

class Animal
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

class Tiger : Animal
{
    public string Habitat { get; private set; }

    public Tiger(string name, int age, string habitat)
        : base(name, age)
    {
        Habitat = habitat;
    }

    public void Roar()
    {
        Console.WriteLine($"{Name} is a tiger living in {Habitat} and roaring!");
    }
}

class Crocodile : Animal
{
    public bool IsAquatic { get; private set; }

    public Crocodile(string name, int age, bool isAquatic)
        : base(name, age)
    {
        IsAquatic = isAquatic;
    }

    public void Swim()
    {
        if (IsAquatic)
            Console.WriteLine($"{Name} is a crocodile swimming in the water.");
        else
            Console.WriteLine($"{Name} is not an aquatic crocodile.");
    }
}

class Kangaroo : Animal
{
    public double JumpHeight { get; private set; }

    public Kangaroo(string name, int age, double jumpHeight)
        : base(name, age)
    {
        JumpHeight = jumpHeight;
    }

    public void Jump()
    {
        Console.WriteLine($"{Name} is a kangaroo jumping to a height of {JumpHeight} meters.");
    }
}

class Program3
{
    static void Main()
    {
        Tiger tiger = new Tiger("Simba", 5, "Jungle");
        Crocodile crocodile = new Crocodile("Croc", 10, true);
        Kangaroo kangaroo = new Kangaroo("Jack", 3, 2.5);

        tiger.Eat();
        tiger.Roar();

        crocodile.Eat();
        crocodile.Swim();

        kangaroo.Eat();
        kangaroo.Jump();
    }
}
