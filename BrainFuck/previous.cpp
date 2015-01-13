#include "previous.h"

using namespace std;

void Previous::execute(Machine &machine, unsigned int &instruction) const
{
    machine.shl();
    ++instruction;
}

