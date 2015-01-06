#include "queue.h"
#include <iostream>
#include <stdlib.h>
#include <exception>
#include <string>

using namespace std;

int main()
{
    int x, qSize = 0;
    Queue queue;
    cout << "Inter queue size: ";
    cin >> qSize;
    for(int i = 0; i < qSize; ++i)
    {
        cin >> x;
        queue.push(x);
    }
    queue.output();
    cout << endl;
    cout << queue.inEnd();
    cout << endl;
    queue.push(10);
    queue.output();
    cout << endl;
    cout << queue.inEnd();
    cout << endl;
    cout << queue.inBegin();
    cout << endl;
    queue.pop();
    queue.output();
    cout << endl;
    cout << queue.inBegin();
    cout << endl;
    return 0;
}
