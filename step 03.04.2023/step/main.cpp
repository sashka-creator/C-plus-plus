#include <iostream>
#include <fstream>
#include <string>
using namespace std;

class Flat {
public:

    double* area;
    double* price;

    Flat(double _area, double _price) {
        area = new double(_area);
        price = new double(_price);
    }


    Flat(const Flat& other) {
        area = new double(*other.area);
        price = new double(*other.price);
    }

    bool operator>(const Flat& other) const {
        return (*price > *other.price);
    }

    double getPrice() const {
        return *price;
    }

    ~Flat() {
        delete area;
        delete price;
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
