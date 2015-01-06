#include "bintree.h"
#include "implementation.h"
#include <utility>

using namespace std;

BinTree::BinTree() : pimpl(nullptr) //Конструктор
{
    pimpl = new Implementation();
}
BinTree::BinTree(const BinTree &original) : pimpl(nullptr)//Конструктор копирования
{
    pimpl = new Implementation(*original.pimpl);
}
BinTree &BinTree::operator=(const BinTree &rhs) //Оператор копирующего присваивания
{
    *pimpl = *rhs.pimpl;
    return *this;
}
BinTree::BinTree(BinTree &&victim) : pimpl(nullptr) //Конструктор перемещения
{
    swap(pimpl, victim.pimpl);
}
BinTree &BinTree::operator=(BinTree &&rhs) //Оператор переместительного присваивания
{
    swap(pimpl, rhs.pimpl);
    return *this;
}
BinTree::~BinTree() //Деструктор
{
    delete pimpl;
    pimpl = nullptr;
}

bool BinTree::search(Data data) const
{
    return pimpl->search(data);
}
void BinTree::add(Data data)
{
    pimpl->add(data);
}
void BinTree::remove(Data data)
{
    pimpl->remove(data);
}

void BinTree::getArrayRepresentation(Data *&array, int &size) const
{
    pimpl->getArrayRepresentation(array, size);
}

bool BinTree::getNext(Data &data, bool firstTime) const
{
    return pimpl->getNext(data,firstTime);
}

void BinTree::acceptVisitor(void (*visitor)(Data)) const
{
    pimpl->acceptVisitor(visitor);
}

