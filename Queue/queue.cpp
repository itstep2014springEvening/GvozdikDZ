#include "queue.h"
#include <iostream>
#include <utility>

using namespace std;

Queue::Queue() : head(nullptr), tail(nullptr) //Конструктор
{

}
Queue::Queue(const Queue &other) : head(nullptr), tail(nullptr) //Конструктор копирования
{
    head = copy(other.head);
    tail = head;
    if(tail)
        while(tail->next)
            tail = tail->next;
}
Queue &Queue::operator=(const Queue &rhs) //Оператор копирующего присваивания
{
    Queue temp(rhs);
    swap(*this, temp);
    return *this;
}
Queue::Queue(Queue &&victim) : head(nullptr), tail(nullptr) //Конструктор перемещения
{
    swap(head, victim.head);
    swap(tail, victim.tail);
}
Queue &Queue::operator=(Queue &&rhs) //Оператор переместительного присваивания
{
    swap(*this, rhs);
    return *this;
}
Queue::~Queue() //Деструктор
{
    clear();
}
Queue::Node *Queue::copy(const Queue::Node *node/*Указатель*/) //Функция
{
    Node *result = nullptr;
    if (node)
    {
            result = new Node(*node);
            result->data = node->data;
            result->next = copy(node->next);
    }
    return result;
}

void Queue::output(Queue::Node *node)
{
    if (node)
    {
        cout << node->data << " ";
        output(node->next);
    }
}
void Queue::push(Data data)
{
    if (head)
    {
        ++size;
        Node *p = new(Node);
        p->next = nullptr;
        p->data = data;
        tail->next = p;
        tail = p;
    }
    else
    {
        head = new(Node);
        tail = head;
        head->data = data;
        head->next = nullptr;
        size = 1;
    }
}
void Queue::pop()
{
    if (!isEmpty())
    {
        Node *p = head;
        head = head->next;
        delete p;
        --size;
    }
}
Data Queue::inBegin() const
{
    if (isEmpty())
        throw exception();
    return head->data;
}

Data Queue::inEnd() const
{
    if (isEmpty())
        throw exception();
    return tail->data;
}
bool Queue::isEmpty()const
{
    return head == nullptr;
}
void Queue::clear()
{
    while (!isEmpty())
    {
        Node *p = head;
        head = head->next;
        delete p;
    }
}

void Queue::output() const
{
    output(head);
}
