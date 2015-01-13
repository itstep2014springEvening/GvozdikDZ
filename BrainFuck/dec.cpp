#include "dec.h"

using namespace std;

void Dec::execute(Machine &machine, unsigned int &instruction) const
{
    machine.dec();
    ++instruction;
}

