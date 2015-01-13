#include "inc.h"

using namespace std;

void Inc::execute(Machine &machine, unsigned int &instruction) const
{
    machine.inc();
    ++instruction;
}

