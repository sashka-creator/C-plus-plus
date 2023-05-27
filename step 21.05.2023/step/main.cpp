#include <iostream>
#include <fstream>
#include <map>
#include <string>

int main() {
    std::string filename = "input.txt";
    std::map<std::string, int> wordFrequency;

    std::ifstream inputFile(filename);
    if (!inputFile.is_open()) {
        std::cerr << "Couldnt Open File: " << filename << std::endl;
        return 1;
    }

    std::string word;
    while (inputFile >> word) {
        // ��������� ���������� ��� �� �����
        std::cout << "Word: " << word << std::endl;

        // ��������� ������� ����� ����� � ��������
        wordFrequency[word]++;
    }

    inputFile.close();

    std::string mostFrequentWord;
    int maxFrequency = 0;
    for (const auto& pair : wordFrequency) {
        std::cout << "Word '" << pair.first << "' have been wroten " << pair.second << " times." << std::endl;
        if (pair.second > maxFrequency) {
            maxFrequency = pair.second;
            mostFrequentWord = pair.first;
        }
    }

    std::cout << "The most used word: '" << mostFrequentWord << "', have been wroten " << maxFrequency << " times." << std::endl;

    std::string outputFilename = "output.txt";
    std::ofstream outputFile(outputFilename);
    if (!outputFile.is_open()) {
        std::cerr << "Couldn't open file for writing: " << outputFilename << std::endl;
        return 1;
    }

    for (const auto& pair : wordFrequency) {
        outputFile << "Word '" << pair.first << "' have been wroten " << pair.second << " times." << std::endl;
    }

    outputFile.close();

    std::cout << "Result was wroten if file: " << outputFilename << std::endl;

    return 0;
}