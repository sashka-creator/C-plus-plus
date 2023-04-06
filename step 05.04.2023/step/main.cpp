#include <iostream>
#include <fstream>
#include <string>
using namespace std;

class var {
public:

    enum Type { INTEGER, DOUBLE, STRING };

    var(int value) {
        m_type = INTEGER;
        m_intValue = value;
    }

    Type m_type;
    int m_intValue;
    double m_doubleValue;
    string m_stringValue;

    var(double value) {
        m_type = DOUBLE;
        m_doubleValue = value;
    }

    var(string value) {
        m_type = STRING;
        m_stringValue = value;
    }

    Type getType() {
        return m_type;
    }

    int getIntValue() {
        if (m_type != INTEGER) {
            throw runtime_error("Cannot get int value of non-integer var");
        }
        return m_intValue;
    }

    double getDoubleValue() {
        if (m_type != DOUBLE) {
            throw runtime_error("Cannot get double value of non-double var");
        }
        return m_doubleValue;
    }

    string getStringValue() {
        if (m_type != STRING) {
            throw runtime_error("Cannot get string value of non-string var");
        }
        return m_stringValue;
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
        var x(42);
        var y(3.141);
        var z("opa");

        cout << "x " << x.getIntValue() << endl;
        cout << "y: " << y.getDoubleValue() << endl;
        cout << "z: " << z.getStringValue() << endl;

        return 0;
    }break;

    }
}
