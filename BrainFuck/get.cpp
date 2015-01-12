#include "get.h"

using namespace std;

Get::Get()
{

}

Get::~Get()
{

}

void Get::execute(Machine &machine, int &instruction) const
{
    machine.get();
}

