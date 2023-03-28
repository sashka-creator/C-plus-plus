#include <iostream>
#include <fstream>
#include <string>
using namespace std;


class Date {
public:
    int day;
    int month;
    int year;
    int result;

    Date(int _day, int _month, int _year) {
        day = _day;
        month = _month;
        year = _year;
    }


    int operator- (const Date& other) const {
        int days1 = day + 31 * (month + 12 * year);
        int days2 = other.day + 31 * (other.month + 12 * other.year);
        int result = abs(days1 - days2);
    }


    inline void Display() {
        cout << result;
    }

    ~Date() {

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
        Date number(1, 2, 2000);
        number.Display();
        
        return 0;
    }break;
    case 2:
    {
        // Я не знаю як це зробити
    }break;

    }
}
