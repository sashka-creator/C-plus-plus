#include <iostream>
#include <queue>
#include <string>
#include <vector>
using namespace std;

class Wheels {
    int count;

    Wheels(int n) : count(n) {}
    void display() { cout << "Кількість коліс: " << count << endl; }
};

class Engine {
    int power;

    Engine(int p) : power(p) {}
    void display() { cout << "Потужність двигуна: " << power << endl; }
};

// клас Двері
class Doors {
    int count;

    Doors(int n) : count(n) {}
    void display() { cout << "Кількість дверей: " << count << endl; }
};

class Car : public Wheels, public Engine, public Doors {

    Car(int nWheels, int power, int nDoors) : Wheels(nWheels), Engine(power), Doors(nDoors) {}
    void display() {
        cout << "Info:" << endl;
        Wheels::display();
        Engine::display();
        Doors::display();
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
        Car myCar(4, 200, 4);
        myCar.display();
        return 0;
    }break;


    }
}

