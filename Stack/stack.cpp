#include "stack.h"
#include <iostream>
#include <utility>

using namespace std;

Stack::Stack() : top(nullptr) //Конструктор
{

}
Stack::Stack(const Stack &original) : top(nullptr) //Конструктор копирования
{
    top = copy(original.top);
}
Stack &Stack::operator=(const Stack &rhs) //Оператор копирующего присваивания
{
    Stack temp(rhs);
    swap(*this, temp);
    return *this;
}
Stack::Stack(Stack &&victim) : top(nullptr) //Конструктор перемещения
{
    swap(top, victim.top);
}
Stack &Stack::operator=(Stack &&rhs) //Оператор переместительного присваивания
{
    swap(*this, rhs);
    return *this;
}
Stack::~Stack() //Деструктор
{
    clear();
}
Stack::Node *Stack::copy(const Stack::Node *originalTop/*Указатель*/) //Функция
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
void Stack::push(Data data)
{
    Node *p = nullptr;
    p = new Node(data);
    p->next = top;
    top = p;
}
void Stack::pop()
{
    if (!isEmpty())
    {
        Node *p = top;
        top = top->next;
        delete p;
    }
}
Data Stack::onTop() const
{
    if (isEmpty())
        throw exception();
    return top->data;
}
bool Stack::isEmpty()const
{
    return top == nullptr;
}
void Stack::clear()
{
    while (!isEmpty())
    {
        Node *p = top;
        top = top->next;
        delete p;
    }
}

Stack::Node::Node(Data data) : data(data), next(nullptr)
{

}

Stack::Node::~Node()
{
    next = nullptr;
}
