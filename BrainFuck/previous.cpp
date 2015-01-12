#include "previous.h"

using namespace std;

Previous::Previous()
{

}

Previous::~Previous()
{

}

void Previous::execute(Machine &machine, int &instruction) const
{
    machine.shl();
    ++instruction;
}

