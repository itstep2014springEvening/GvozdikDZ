#include <iostream>
#include "consolestack.h"

using namespace std;

int main()
{
    ConsoleStack stack;
    for(int i = 0; i<10; ++i)
    {
        stack.push(i);
        stack.output();
    }
    for(int i = 0; i<5; ++i)
    {
        cout << stack.onTop() << endl;
        stack.pop();
        stack.output();
    }
    for(int i = 20; i<30; ++i)
    {
        stack.push(i);
        stack.output();
    }
    while(!stack.isEmpty())
    {
        cout << stack.onTop() << endl;
        stack.pop();
        stack.output();
    }
    return 0;
}
