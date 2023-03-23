#include <iostream>
#include <fstream>
#include <string>
#include <vector>
using namespace std;

class Person {
public:
    Person(std::string name) : m_name(name) {}
    Person(const Person& other) : m_name(other.m_name) {}
    ~Person() {}

    std::string getName() const { return m_name; }
    std::string m_name;
};

class Apartment {
public:
    Apartment(int number) : m_number(number) {}
    Apartment(const Apartment& other) : m_number(other.m_number) {}
    ~Apartment() {}

    void addPerson(const Person& person) { m_people.push_back(person); }

    void printResidents() const {
        std::cout << "Residents of apartment " << m_number << ":\n";
        for (const auto& person : m_people) {
            std::cout << "- " << person.getName() << "\n";
        }
        std::cout << "\n";
    }
    int m_number;
    std::vector<Person> m_people;

};

class Building {
public:
    Building(int numApartments) : m_numApartments(numApartments) {
        for (int i = 0; i < numApartments; i++) {
            m_apartments.push_back(Apartment(i + 1));
        }
    }
    Building(const Building& other) : m_numApartments(other.m_numApartments), m_apartments(other.m_apartments) {}
    ~Building() {}

    void addPersonToApartment(const Person& person, int apartmentNum) {
        if (apartmentNum > 0 && apartmentNum <= m_numApartments) {
            m_apartments[apartmentNum - 1].addPerson(person);
        }
    }

    void printResidents() const {
        std::cout << "Residents of the building:\n";
        for (const auto& apartment : m_apartments) {
            apartment.printResidents();
        }
    }

    int m_numApartments;
    std::vector<Apartment> m_apartments;
};

using namespace std;
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
        Building building(3);

        building.addPersonToApartment(Person("Vlad Lisenko"), 1);
        building.printResidents();

    }break;

    }
}