#include "inc.h"

using namespace std;

Inc::Inc()
{

}

Inc::~Inc()
{

}

void Inc::execute(Machine &machine, int &instruction) const
{
    machine.inc();
    ++instruction;
}

