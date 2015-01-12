#include "close.h"

using namespace std;

Close::Close(int neighbour) : neighbour(neighbour)
{    
}

Close::~Close()
{

}

void Close::execute(Machine &machine, int &instruction) const
{
    if(machine.get())
        instruction = neighbour;
    else
       ++instruction;
}

