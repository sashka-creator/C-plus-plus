#include <iostream>
#include <fstream>
#include <string>
using namespace std;


class Overcoat {
public:

    string type;
    string size;
    string color;
    double price;

    Overcoat(string _type, string _size, string _color, double _price) {
        type = _type;
        size = _size;
        color = _color;
        price = _price;
    }

    bool operator>(const Overcoat& other) const {
        if (type == other.type) {
            return price > other.price;
        }
        return false;
    }

    double getPrice() const {
        return price;
    }

};

class Flat {
public:

    double area;
    double price;

    Flat(int _area, double _price) {
        area = _area;
        price = _price;
    }

    bool operator>(const Flat& other) const {
        return (price > other.price);
    }

    double getPrice() const {
        return price;
    }

};

int main()
{

    cout << "\t\t\t#>---------<MENU>---------<#" << endl;
    cout << "\t\t\t|    1 - Task_1            |" << endl;
    cout << "\t\t\t|    2 - Task_2            |" << endl;
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
        Overcoat coat1("trenchcoat", "M", "black", 150.0);
        Overcoat coat2("peacoat", "L", "navy", 120.0);

        coat2 = coat1;
        std::cout << "Coat 1: " << coat1.getPrice() << ", Coat 2: " << coat2.getPrice() << std::endl;

        if (coat1 > coat2) {
            std::cout << "Coat 1 is more expensive than Coat 2" << std::endl;
        }
        else {
            std::cout << "Coat 2 is more expensive than Coat 1" << std::endl;
        }
        
        return 0;
    }break;

    case 2:
    {
        Flat flat1(35.0, 35000.0);
        Flat flat2(45.0, 45000.0);

        flat2 = flat1;
        std::cout << "Flat 1: " << flat1.getPrice() << ", Flat 2: " << flat2.getPrice() << std::endl;

        if (flat1 > flat2) {
            std::cout << "Flat 1 is more expensive than Flat 2" << std::endl;
        }
        else {
            std::cout << "Flat 2 is more expensive than Flat 1" << std::endl;
        }

        return 0;
    }break;

    }
}
