#include <iostream>
#include <fstream>
#include <string>


using namespace std;
namespace MyNamespace {
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
}


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
        MyNamespace::School my_school("ABC School", 10, "123456", "New York", "USA");
        my_school.Display();
        
        return 0;
    }break;


    }
}
