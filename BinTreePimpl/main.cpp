#include <iostream>
#include "prettybintree.h"

using namespace std;

int main()
{
    ConsoleBinTree *binTree;
    cout<<"Choose\n1. Simple\n2. Pretty\n";
    int choise;
    cin >> choise;
    switch(choise)
    {
    case 1:
        binTree = new ConsoleBinTree;
        break;
    case 2:
        binTree = new PrettyBinTree;
        break;
    }

    binTree->output();
    return 0;
}
