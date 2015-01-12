#include "next.h"

using namespace std;

Next::Next()
{

}

Next::~Next()
{

}

void Next::execute(Machine &machine, int &instruction) const
{
    machine.shr();
    ++instruction;
}

