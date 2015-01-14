#include "machine.h"

using namespace std;

Machine::Machine() : head(0)
{
    for(int i = 0; i < 30000; ++i)
        array[i] = 0;
}

Machine::~Machine()
{

}

void Machine::inc()
{
    ++array[head];
}

void Machine::dec()
{
    --array[head];
}

void Machine::shl()
{
    head--;
}

void Machine::shr()
{
    head++;
}

void Machine::write(char c)
{
    array[head] = c;
}

char Machine::read() const
{
   return array[head];
}

