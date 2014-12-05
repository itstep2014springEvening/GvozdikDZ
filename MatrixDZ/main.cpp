#include "Matrix.h"
#include <iostream>
#include <stdlib.h>
#include <exception>

using namespace std;

int main()
{
	Matrix a(0,0), b(0,0);
	a.input();
	b.input();
	a.output();
	b.output();
	(a.addition(b)).output();
	(a.subtraction(b)).output();
	(a.multiplication(b)).output();
	return 0;
}