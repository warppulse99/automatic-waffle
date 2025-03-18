#include <iostream>
#include <chrono>
#include <thread>

using namespace std;
using namespace chrono;

int main() {
    cout << "⏳ Press Enter to start the stopwatch...";
    cin.ignore();
    auto start = steady_clock::now();

    cout << "⏹ Press Enter to stop...";
    cin.ignore();
    auto end = steady_clock::now();

    duration<double> elapsed = end - start;
    cout << "⏰ Elapsed time: " << elapsed.count() << " seconds" << endl;

    return 0;
}
