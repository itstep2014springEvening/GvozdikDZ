#include "matrix.h"
#include <iostream>
#include <stdlib.h>
#include <exception>

using namespace std;

int main()
{
    Matrix a(5,4);
    Matrix b(7,6);
    a.output();
    b.output();
    (a.addition(b)).output();
    (a.subtraction(b)).output();
    (a.multiplication(b)).output();
    return 0;
}
