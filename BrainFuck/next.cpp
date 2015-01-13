#include "next.h"

using namespace std;

void Next::execute(Machine &machine, unsigned int &instruction) const
{
    machine.shr();
    ++instruction;
}

