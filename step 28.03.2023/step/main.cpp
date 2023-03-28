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

    inline void Dodavanya() {
        cout << a + b;
    }

    inline void Vidnimanya() {
        cout << a - b;
    }

    inline void Mnojena() {
        cout << a * b;
    }

    inline void Dilena() {
        cout << a / b;
    }

    ~Drib() {

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
        Drib number(2, 2);
        number.Dodavanya();
        
        return 0;
    }break;

    }
}
