#include "open.h"

using namespace std;

Open::Open(int neighbour) : neighbour(neighbour)
{

}

Open::~Open()
{

}

void Open::execute(Machine &machine, unsigned int &instruction) const
{
    if(!machine.read())
        instruction = neighbour;
    else
       ++instruction;
}

