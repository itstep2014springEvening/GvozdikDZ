#include "dec.h"

using namespace std;

Dec::Dec()
{

}

Dec::~Dec()
{

}

void Dec::execute(Machine &machine, int &instruction) const
{
    machine.dec();
    ++instruction;
}

