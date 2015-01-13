#include "write.h"
#include <iostream>

using namespace std;

void Write::execute(Machine &machine, unsigned int &instruction) const
{
    char c = machine.write();
    cout.put(c);
    ++instruction;
}

