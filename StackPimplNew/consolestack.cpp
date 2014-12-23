#include "consolestack.h"
#include <iostream>

using namespace std;

void simpleConsoleVisitor(Data data)
{
    cout<<data<<" ";
}

void ConsoleStack::output() const
{
    outputImplementaion();
}

void ConsoleStack::outputImplementaion() const
{
    /*Data *array = nullptr;
    int size;
    getArrayRepresentation(array, size);
    for(int i = 0; i < size; ++i)
        cout << array[i] << " ";
    cout << endl;
    delete [] array;
    array = nullptr;*/
    /*Data data;
    if(getNext(data, true))
        cout << data << " ";
    while(getNext(data))
        cout << data << " ";
    cout << endl;*/
    acceptVisitor(simpleConsoleVisitor);
    cout<<endl;
}
