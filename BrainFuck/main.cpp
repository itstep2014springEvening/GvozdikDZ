#include <iostream>

#include "machine.h"
#include "open.h"
#include "close.h"
#include "inc.h"
#include "dec.h"
#include "next.h"
#include "previous.h"
#include "get.h"
#include "put.h"

#include <vector>
#include <stack>

using namespace std;

int main()
{
    vector<Term *> userProgramm;
    stack<int> userStack;
    int increment = 0;
    while(f.eof())
    {
        char c = f.get();
        switch(c)
        {
        case '-':
            userProgramm.push_back(new Dec);
            break;
        case '[':
            userProgramm.push_back(nullptr);
            userStack.push(increment);
            break;
        case ']':
            userProgramm.push_back(new Close(userStack.top()));
            userProgramm[userStack.top] = new Open(increment);
            userStack.pop();
            break;
        }
    }
    Machine machine;
    for(int increment =0; increment < userProgramm.size(); )
        userProgramm[increment]->execute(machine, increment);
    return 0;
}

