#include "vector.h"
#include <iostream>

using namespace std;

int main()
{
    Vector a(0, 0, 0), b(0, 0, 0);
    a.input();
    b.input();
    a.output();
    b.output();
    (a.sum(b)).output();
    (a.sub(b)).output();
    cout << (a.vectorProd(b)) << endl;
    (a.geomProd(b)).output();
    return 0;
}

