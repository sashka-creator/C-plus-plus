#include <iostream>
#include <thread>

void threadFunction(int threadId) {
    std::cout << "Hello from thread " << threadId << "!" << std::endl;
}

int main() {

    const int numThreads = 5;
    std::thread threads[numThreads];

    for (int i = 0; i < numThreads; ++i) {
        threads[i] = std::thread(threadFunction, i);
    }

    for (int i = 0; i < numThreads; ++i) {
        threads[i].join();
    }

    return 0;
}