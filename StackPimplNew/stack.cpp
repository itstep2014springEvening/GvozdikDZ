#include "stack.h"
#include "implementation.h"
#include <utility>

using namespace std;

Stack::Stack():
    pimpl(nullptr)
{
    pimpl = new Implementation();
}

Stack::Stack(const Stack &original):
    pimpl(nullptr)
{
    pimpl = new Implementation(*original.pimpl);
}

Stack &Stack::operator=(const Stack &rhs)
{
    *pimpl = *rhs.pimpl;
    return *this;
}

Stack::Stack(Stack &&victim):
    pimpl(nullptr)
{
    swap(pimpl, victim.pimpl);
}

Stack &Stack::operator=(Stack &&rhs)
{
    swap(pimpl, rhs.pimpl);
    return *this;
}

Stack::~Stack()
{
    delete pimpl;
    pimpl = nullptr;
}

void Stack::push(Data data)
{
    pimpl->push(data);
}

void Stack::pop()
{
    pimpl->pop();
}

Data Stack::onTop() const
{
    return pimpl->onTop();
}

bool Stack::isEmpty() const
{
    return pimpl->isEmpty();
}

void Stack::clear()
{
    pimpl->clear();
}

void Stack::getArrayRepresentation(Data *&array, int &size) const
{
    pimpl->getArrayRepresentation(array, size);
}

bool Stack::getNext(Data &data, bool firstTime) const
{
    return pimpl->getNext(data,firstTime);
}

void Stack::acceptVisitor(void (*visitor)(Data)) const
{
    pimpl->acceptVisitor(visitor);
}
