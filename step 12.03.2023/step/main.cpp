#include <iostream>
#include <fstream>
#include <string>
using namespace std;

class Drib {
public:
    int a;
    int b;

    Drib(int _a, int _b) {
        a = _a;
        b = _b;
    }

    void Dodavanya() {
        cout << a + b;
    }

    void Vidnimanya() {
        cout << a - b;
    }

    void Mnojena() {
        cout << a * b;
    }

    void Dilena() {
        cout << a / b;
    }

    ~Drib() {
        
    }

};

class School {
public:
    string name;
    int age;
    string number;
    string city;
    string country;

    School(string _name, int _age, string _number, string _city, string _country) {
        name = _name;
        age = _age;
        number = _number;
        city = _city;
        country = _country;
    }

    void Display() {
        cout << "Name " << name << "; Age " << age << "; Number" << number << "; City " << city << "; Country " << country;
    }

    ~School() {
        
    }

};

class Point {
public: 
    int x;
    int y;
    int z;

    Point(int _x, int _y, int _z) {
        x = _x;
        y = _y;
        z = _z;
    }

    void Display() {
        cout << "x " << x << "; y " << y << "; z " <<  z;
    }

    ~Point() {

    }
};

using namespace std;
int main()
{

    cout << "\t\t\t#>---------<MENU>---------<#" << endl;
    cout << "\t\t\t|    1 - Task_1            |" << endl;
    cout << "\t\t\t|    2 - Task_2            |" << endl;
    cout << "\t\t\t|    3 - Task_3            |" << endl;
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
        Drib result(5, 5);
        result.Dodavanya();
        
        return 0;
    }break;

    case 2:
    {
        School student("Sasha", 15, "mobile", "Vinnitsa", "Ukraine");
        student.Display();

        return 0;

    }break;

    case 3:
    {
        Point pointOne(1, 2, 3);
        pointOne.Display();

        return 0;

    }break;

    }
}
