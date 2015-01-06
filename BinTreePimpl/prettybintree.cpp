#include "prettybintree.h"
#include <iostream>

using namespace std;

void prettyConsoleVisitor(Data data)
{
    cout << "<-" << data;
}

void PrettyBinTree::outputImplementaion() const
{
    acceptVisitor(prettyConsoleVisitor);
    cout << endl;
}
