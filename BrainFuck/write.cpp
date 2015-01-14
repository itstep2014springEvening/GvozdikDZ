#include "write.h"
#include <iostream>

using namespace std;

void Write::execute(Machine &machine, unsigned int &instruction) const
{
    char c = cin.get();
    machine.write(c);
    ++instruction;
}

