#include <iostream>
#include <fstream>
#include <string>
using namespace std;

class Math {
public:
    int a;
    int b;
    int c;
    int d;

    Math(int _a, int _b, int _c, int _d) {
        a = _a;
        b = _b;
        c = _c;
        d = _d;

    }

    void SquareTriangle() {
        cout << a * b * c;
    }

    void SquareRectangle() {
        cout << a * b * c * d;
    }

    void SquareRomb() {
        cout << (a * b) * (c * d);
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
        Math result(5, 5, 4, 4);
        result.SquareRectangle();
        
        return 0;
    }break;

    }
}
