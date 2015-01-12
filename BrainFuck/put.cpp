#include "put.h"

using namespace std;

Put::Put()
{

}

Put::~Put()
{

}

void Put::execute(Machine &machine, int &instruction) const
{
    machine.set();
}

