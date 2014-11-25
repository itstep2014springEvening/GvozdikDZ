#include "vector.h"
#include <iostream>

using namespace std;

int main()
{
    Vector a(2, 7, -3.5), b(1, -4, 0);
    a.output();
    b.output();
    (a.sum(b)).output();
    (a.sub(b)).output();
    cout << (a.vectorProd(b)) << endl;
    (a.geomProd(b)).output();
    return 0;
}

