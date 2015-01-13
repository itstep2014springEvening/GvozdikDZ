#include "read.h"
#include <iostream>

using namespace std;

void Read::execute(Machine &machine, unsigned int &instruction) const
{
    char c = cin.get();
    machine.read(c);
    ++instruction;
}

