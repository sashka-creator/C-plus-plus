#include <iostream>
#include <queue>
#include <string>
#include <vector>
using namespace std;


class HomePet {
protected:
    string name;
    int age;
    float weight;
public:
    HomePet(string n, int a, float w) {
        name = n;
        age = a;
        weight = w;
    }
};

class Dog : public HomePet {
private:
    string breed;
public:
    Dog(string n, int a, float w, string b) : HomePet(n, a, w) {
        breed = b;
    }
};

class Cat : public HomePet {
private:
    string color;
public:
    Cat(string n, int a, float w, string c) : HomePet(n, a, w) {
        color = c;
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
        Dog dog("Rex", 2, 10.5, "Golden Retriever");
        Cat cat("Fluffy", 4, 5.2, "Gray");

        return 0;
    }break;


    }
}
