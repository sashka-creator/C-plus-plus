#include <iostream>
#include <fstream>
#include <string>
using namespace std;


class Reservoir {
public:

    string name;
    int width;
    int lenght;
    int depth;
    string type;

    explicit Reservoir(string _name, int _width, int _lenght, int _depth, string _type) {
        name = _name;

        width = _width;
        lenght = _lenght;
        depth = _depth;

        type = _type;
    }

    inline void Capacity() {
        cout << "Capacity " << width * lenght * depth;
    }

    inline void Area() {
        cout << "Area " << width * lenght;
    }

    inline void Type() {
        cout << "Type of reservoir " << type;
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
        Reservoir reservoirOne("Missisipi", 1500, 3000, 500, "River");
        reservoirOne.Capacity();
        
        return 0;
    }break;

    }
}
