#include "close.h"

using namespace std;

Close::Close(int neighbour) : neighbour(neighbour)
{    

}

Close::~Close()
{

}

void Close::execute(Machine &machine, unsigned int &instruction) const
{
    if(machine.read())
        instruction = neighbour;
    else
       ++instruction;
}

