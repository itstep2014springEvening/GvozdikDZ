#include <iostream>
#include "prettystack.h"



using namespace std;

int main()
{
    ConsoleStack *stack;
    cout<<"chose\n1. Simple\n2. Pretty\n";
    int choise;
    cin>>choise;
    switch(choise)
    {
    case 1:
        stack=new ConsoleStack;
        break;
    case 2:
        stack =new PrettyStack;
        break;
    }

    stack->output();
    for(int i = 0; i < 10; ++i)
    {
        stack->push(i);
        stack->output();
    }
    for(int i = 0; i<5; ++i)
    {
        cout<<stack->onTop()<<endl;
        stack->pop();
        stack->output();
    }
    for(int i=20;i < 30;++i)
    {
        stack->push(i);
        stack->output();
    }
    while (!stack->isEmpty())
    {
        cout<<stack->onTop()<<endl;
        stack->pop();
        stack->output();
    }
    return 0;
}
