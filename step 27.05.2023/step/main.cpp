#include <vector>
#include <algorithm>
#include <iostream>

class LambdaSorter {
public:
    std::vector<int> sort(const std::vector<int>& numbers, bool reverse = false) const {
        std::vector<int> sorted_numbers = numbers;
        std::sort(sorted_numbers.begin(), sorted_numbers.end(),
            [](int a, int b) { return a < b; });

        if (reverse) {
            std::reverse(sorted_numbers.begin(), sorted_numbers.end());
        }

        return sorted_numbers;
    }
};

int main() {
    std::vector<int> numbers = { 5, 2, 8, 1, 9 };

    LambdaSorter sorter;
    std::vector<int> ascending_sorted_numbers = sorter.sort(numbers);
    std::vector<int> descending_sorted_numbers = sorter.sort(numbers, true);

    std::cout << "Ascending order: ";
    for (int num : ascending_sorted_numbers) {
        std::cout << num << " ";
    }

    std::cout << std::endl;

    std::cout << "Descending order: ";
    for (int num : descending_sorted_numbers) {
        std::cout << num << " ";
    }

    return 0;
}


