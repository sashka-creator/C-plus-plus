#include <iostream>
#include <vector>
#include <fstream>

using namespace std;

struct Transaction {
    string name;
    double amount;
    string category;
    string date;
};

class Wallet {
private:
    string name;
    double balance;
    vector<Transaction> transactions;
public:
    Wallet(string n, double b) {
        name = n;
        balance = b;
    }
    double get_balance() {
        return balance;
    }
    void deposit(double amount) {
        balance += amount;
    }
    bool withdraw(double amount) {
        if (balance >= amount) {
            balance -= amount;
            return true;
        }
        return false;
    }
    void add_transaction(string n, double amount, string category, string date) {
        Transaction t = { n, amount, category, date };
        transactions.push_back(t);
        balance -= amount;
    }
    vector<Transaction> get_transactions_by_day(string date) {
        vector<Transaction> result;
        for (int i = 0; i < transactions.size(); i++) {
            if (transactions[i].date == date) {
                result.push_back(transactions[i]);
            }
        }
        return result;
    }
    vector<Transaction> get_transactions_by_week(string start_date, string end_date) {
        vector<Transaction> result;
        for (int i = 0; i < transactions.size(); i++) {
            if (transactions[i].date >= start_date && transactions[i].date <= end_date) {
                result.push_back(transactions[i]);
            }
        }
        return result;
    }
    vector<Transaction> get_transactions_by_month(string month) {
        vector<Transaction> result;
        for (int i = 0; i < transactions.size(); i++) {
            if (transactions[i].date.substr(0, 7) == month) {
                result.push_back(transactions[i]);
            }
        }
        return result;
    }
    void save_transactions_to_file(string filename) {
        ofstream file(filename);
        for (int i = 0; i < transactions.size(); i++) {
            file << transactions[i].name << "," << transactions[i].amount << "," << transactions[i].category << "," << transactions[i].date << endl;
        }
        file.close();
    }
};

int main() {
    Wallet w("Main", 1000.0);
    w.deposit(500.0);
    w.withdraw(100.0);
    w.add_transaction("Groceries", 50.0, "Food", "2023-04-10");
    w.add_transaction("Gas", 30.0, "Transportation", "2023-04-11");
    vector<Transaction> day_transactions = w.get_transactions_by_day("2023-04-10");
    vector<Transaction> week_transactions = w.get_transactions_by_week("2023-04-01", "2023-04-11");
    vector<Transaction> month_transactions = w.get_transactions_by_month("2023-04");
    w.save_transactions_to_file("transactions.txt");
    return 0;
}