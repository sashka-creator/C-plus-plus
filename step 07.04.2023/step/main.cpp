#include <iostream>
#include <fstream>
#include <string>
#include <vector>
using namespace std;

class Booking {
public:

    int seatNumber;
    string username;
    string date;

    Booking(int _seatNumber, string _username, string _date) {
        seatNumber = _seatNumber;
        username = _username;
        date = _date;
    }

    vector<Booking> bookings;

    void bookSeat(int seatNumber, string username, string date) {
        Booking booking(seatNumber, username, date);
        bookings.push_back(booking);
    }

    void viewBookings() {
        if (bookings.empty()) {
            cout << "No bookings found." << endl;
        }
        else {
            cout << "Bookings:" << endl;
            for (const auto& booking : bookings) {
                cout << "Seat number: " << booking.seatNumber << ", ";
                cout << "Username: " << booking.username << ", ";
                cout << "Date: " << booking.date << endl;
            }
        }
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
        int seatNumber;

        return 0;
    }break;

    }
}
