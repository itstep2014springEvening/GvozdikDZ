#include "prettystack.h"
#include <iostream>

using namespace std;

void prettyConsoleVisitor(Data data)
{
    cout<<"<-"<<data;
}

void PrettyStack::outputImplementaion() const
{
    acceptVisitor(prettyConsoleVisitor);
    cout<<endl;
}
