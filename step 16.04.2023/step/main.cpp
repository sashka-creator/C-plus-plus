#include <iostream>
#include <queue>
#include <string>
#include <vector>
using namespace std;

template <typename T>
class Queue {
private:
    struct Node {
        T data;
        Node* next;
        Node* prev;

        Node(T value, Node* nxt = nullptr, Node* prv = nullptr) {
            data = value;
            next = nxt;
            prev = prv;
        }
    };

    Node* head;
    Node* tail;
    int size;

public:
    Queue() {
        head = nullptr;
        tail = nullptr;
        size = 0;
    }

    bool isEmpty() {
        return size == 0;
    }

    void enqueue(T value) {
        Node* newNode = new Node(value);
        if (isEmpty()) {
            head = newNode;
            tail = newNode;
        }
        else {
            tail->next = newNode;
            newNode->prev = tail;
            tail = newNode;
        }
        size++;
    }

    T dequeue() {
        if (isEmpty()) {
            std::cerr << "Queue is empty!" << std::endl;
            exit(1);
        }
        T data = head->data;
        Node* temp = head;
        if (head == tail) {
            head = nullptr;
            tail = nullptr;
        }
        else {
            head = head->next;
            head->prev = nullptr;
        }
        delete temp;
        size--;
        return data;
    }

    int getSize() {
        return size;
    }

    T& front() {
        if (isEmpty()) {
            std::cerr << "Queue is empty!" << std::endl;
            exit(1);
        }
        return head->data;
    }

    T& back() {
        if (isEmpty()) {
            std::cerr << "Queue is empty!" << std::endl;
            exit(1);
        }
        return tail->data;
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
        Queue<int> queue;

        queue.enqueue(1);

        std::cout << "Queue size: " << queue.getSize() << std::endl;
        std::cout << "Front element: " << queue.front() << std::endl;
        std::cout << "Back element: " << queue.back() << std::endl;
        std::cout << "Dequeued element: " << queue.dequeue() << std::endl;
        std::cout << "Queue size: " << queue.getSize() << std::endl;
        return 0;
    }break;


    }
}