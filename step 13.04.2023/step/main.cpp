#include <iostream>
#include <queue>
#include <string>
#include <vector>
using namespace std;

class Node {
public:

    int data;
    Node* next;

    Node(int value) {
        data = value;
        next = nullptr;
    }
};

class Stack {
public:

    Node* topNode;
    int size;

    Stack() {
        topNode = nullptr;
        size = 0;
    }

    bool isEmpty() {
        return topNode == nullptr;
    }

    void push(int value) {
        Node* newNode = new Node(value);
        if (isEmpty()) {
            topNode = newNode;
        }
        else {
            newNode->next = topNode;
            topNode = newNode;
        }
        size++;
    }

    int getSize() {
        return size;
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
        Stack stack;

        stack.push(5);

        cout << "Stack size: " << stack.getSize() << endl;

        return 0;
    }break;


    }
}