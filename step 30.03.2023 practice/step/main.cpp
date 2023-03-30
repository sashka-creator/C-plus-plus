#include <iostream>
#include <fstream>
#include <string>
using namespace std;


class Circle {
public:

    double radius;
    double lenght;

    Circle(double _radius, double _lenght) {
        radius = _radius;
        lenght = _lenght;
    }

    bool operator==(const Circle& other) const {
        return (radius == other.radius);
    }

    double operator+(const Circle& other) const {
        if (lenght > other.lenght) {

            return lenght > other.lenght;
        }
    }

    double getLenght() const {
        return lenght;
    }

};

int main()
{

    cout << "\t\t\t#>---------<MENU>---------<#" << endl;
    cout << "\t\t\t|    1 - Task_1            |" << endl;
    cout << "\t\t\t#>------------------------<#" << endl;
    cout << "\t\t\t|    Exit - 0              |" << endl;
    cout << "\t\t\t#>------------------------<#" << endl;
    int number;
    cin >> number;
    system("cls");
    switch (number)
    {
    case 1:
    {
        Circle circle1(20, 20);
        Circle circle2(15, 25);

        circle1 = circle2;
        std::cout << "Circle 1: " << circle1.getLenght() << ", Circle  2: " << circle2.getLenght() << std::endl;

        if (circle1 + circle2) {
            std::cout << "Circle 1 longer" << std::endl;
        }
        else {
            std::cout << "Coat 2 longer" << std::endl;
        }
        
        return 0;
    }break;


    }
}
