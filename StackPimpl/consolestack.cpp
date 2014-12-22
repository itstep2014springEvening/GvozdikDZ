#include "consolestack.h"
#include <iostream>

using namespace std;

void ConsoleStack::output() const
{
    Data *array = nullptr;
    int size;
    getArrayRepresentation(array, size);
    for(int i = 0; i < size; ++ i)
    {
        cout << array[i] << ' ';
    }
    cout << endl;
}

