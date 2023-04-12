#include <iostream>
#include <queue>
#include <string>
#include <vector>
using namespace std;

class PrintJob {
public:
    string user;
    int priority;
    string data;

    PrintJob(string _user, int _priority, string _data) : user(_user), priority(_priority), data(_data) {}

    bool operator<(const PrintJob& other) const {
        return priority < other.priority;
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
        priority_queue<PrintJob> printQueue;
        vector<PrintJob> printHistory;

        while (true) {
            cout << "Enter a print job (user priority data): ";
            string user, data;
            int priority;
            cin >> user >> priority >> data;

            if (user == "exit") {
                break;
            }

            PrintJob newJob(user, priority, data);
            printQueue.push(newJob);
            cout << "Job added to queue." << endl;
        }

        cout << "Printing jobs..." << endl;

        while (!printQueue.empty()) {
            PrintJob currentJob = printQueue.top();
            printQueue.pop();

            cout << "Printing job for user " << currentJob.user << " with priority " << currentJob.priority << ": " << currentJob.data << endl;

            printHistory.push_back(currentJob);
        }

        cout << endl << "Printing history:" << endl;
        for (const auto& job : printHistory) {
            cout << job.user << " - " << job.priority << " - " << job.data << endl;
        }

        return 0;
    }break;


    }
}