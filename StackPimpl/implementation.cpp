#include "implementation.h"

#include <utility>
#include <exception>

using namespace std;

Stack::Implementation::Implementation() : top(nullptr) //Конструктор
{

}

Stack::Implementation::Implementation(const Stack::Implementation &original) : top(nullptr) //Конструктор копирования
{
    top = copy(original.top);
}

Stack::Implementation &Stack::Implementation::operator=(const Stack::Implementation &rhs) //Оператор копирующего присваивания
{
    Implementation temp(rhs);
    swap(*this, temp);
    return *this;
}

Stack::Implementation::Implementation(Stack::Implementation &&victim) : top(nullptr) //Конструктор перемещения
{
    swap(top, victim.top);
}
Stack::Implementation &Stack::Implementation::operator=(Stack::Implementation &&rhs) //Оператор переместительного присваивания
{
    swap(*this, rhs);
    return *this;
}

Stack::Implementation::~Implementation() //Деструктор
{
    clear();
}

Stack::Implementation::Node *Stack::Implementation::copy(const Stack::Implementation::Node *originalTop/*Указатель*/) //Функция
{
    Node *newTop = nullptr;
    Node *p = nullptr;
    const Node *q = originalTop;
    p = new Node(q->data);
    newTop = p;
    q = q->next;
    while (q != nullptr)
    {
        Node *r = nullptr;
        r = new Node(q->data);
        p->next = r;
        p = p->next;
        q = q->next;
    }
    return newTop;
}

void Stack::Implementation::push(Data data)
{
    Node *p = nullptr;
    p = new Node(data);
    p->next = top;
    top = p;
}

void Stack::Implementation::pop()
{
    if (!isEmpty())
    {
        Node *p = top;
        top = top->next;
        delete p;
    }
}

Data Stack::Implementation::onTop() const
{
    if (isEmpty())
        throw exception();
    return top->data;
}

bool Stack::Implementation::isEmpty() const
{
    return top == nullptr;
}

void Stack::Implementation::clear()
{
    while (!isEmpty())
    {
        Node *p = top;
        top = top->next;
        delete p;
    }
}

void Stack::Implementation::getArrayRepresentation(Data *&array, int &size) const
{
    size = 0;
    Node *p = top;
    while(p)
    {
        ++size;
        p = p->next;
    }
    array = new Data[size];
    int i = size - 1;
    p = top;
    while(p)
    {
        array[i] = p->data;
        --i;
        p = p->next;
    }
}

Stack::Implementation::Node::Node(Data data) : data(data), next(nullptr)
{

}

Stack::Implementation::Node::~Node()
{
    next = nullptr;
}

