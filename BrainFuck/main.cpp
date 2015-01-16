#include <iostream>
#include <fstream>

#include "machine.h"
#include "open.h"
#include "close.h"
#include "inc.h"
#include "dec.h"
#include "next.h"
#include "previous.h"
#include "read.h"
#include "write.h"

#include <vector>
#include <stack>

using namespace std;

int main()
{
    vector<Term *> userProgramm;
    stack<int> userStack;
    int increment = 0;

    ifstream f("input.txt");

    while(!f.eof())
    {
        char c = f.get();
        if(c!=' ' && c!='\n')
        {
            cout.put(c);
            switch(c)
            {
            case '+':
               userProgramm.push_back(new Inc);
               break;
            case '-':
               userProgramm.push_back(new Dec);
              break;
            case '.':
              userProgramm.push_back(new Read);
              break;
            case ',':
                userProgramm.push_back(new Write);
                break;
            case '>':
                userProgramm.push_back(new Next);
                break;
            case '<':
                userProgramm.push_back(new Previous);
                break;
            case '[':
                userProgramm.push_back(nullptr);
                userStack.push(increment);
                break;
            case ']':
                userProgramm.push_back(new Close(userStack.top()));
                userProgramm[userStack.top()] = new Open(increment);
                userStack.pop();
                break;
            }
            ++increment;
        }
    }
    Machine machine;
    cout<<endl;
    for(unsigned int increment = 0; increment < userProgramm.size(); )
        userProgramm[increment]->execute(machine, increment);

    for(unsigned int increment = 0; increment < userProgramm.size(); )
        delete userProgramm[increment];
    return 0;
}

