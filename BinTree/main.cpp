#include "bintree.h"
#include <iostream>
#include <stdlib.h>
#include <exception>
#include <string>

using namespace std;

int main()
{
    int a, size = 0;
    BinTree tree;
    cout << "Enter size: ";
    cin >> size;
    for (int i = 0; i < size; i++)
    {
        cin >> a;
        tree.add(a);
    }
    tree.output();
    if (tree.search(4))
        cout << "True" << endl;
    else
        cout << "False" << endl;
    tree.add(10);
    tree.output();
    cout << endl;
    tree.remove(10);
    tree.output();
    return 0;
}
