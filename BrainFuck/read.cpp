#include "read.h"
#include <iostream>

using namespace std;

void Read::execute(Machine &machine, unsigned int &instruction) const
{
    char c = machine.read();
    cout.put(c);
    ++instruction;
}

