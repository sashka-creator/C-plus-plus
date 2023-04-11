#include <iostream>
#include <fstream>
#include <string>
using namespace std;

class CharStack {
private:

    char* arr;
    int top;
    int size;

public:
    CharStack(int _size) {
        size = _size;
        arr = new char[size];
        top = -1;
    }

    bool isEmpty() {
        return top == -1;
    }

    bool isFull() {
        return top == size - 1;
    }

    void push(char c) {
        if (isFull()) {
            cout << "Stack is full!" << endl;
            return;
        }
        top++;
        arr[top] = c;
    }

    char peek() {
        if (isEmpty()) {
            cout << "Stack is empty!" << endl;
            return '\0';
        }
        return arr[top];
    }

    int count() {
        return top + 1;
    }

    void clear() {
        top = -1;
    }

    ~CharStack() {
        delete[] arr;
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
        CharStack stack(5);
        stack.push('a');

        return 0;
    }break;

    }
}
