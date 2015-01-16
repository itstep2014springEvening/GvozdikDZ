#ifndef STACK_H
#define STACK_H
#include <iostream>
#include <utility>

using namespace std;

//typedef int Data;

template<typename T>
class Stack
{
public:
    Stack(); //Конструктор
    Stack(const Stack &original); //Конструктор копирования
    Stack &operator=(const Stack &rhs);  //Оператор присваивания
    Stack(Stack &&victim); //Конструктор перемещения
    Stack &operator=(Stack &&rhs); //Оператор переместительного присваивания
    ~Stack(); //Деструктор
    void push(T value);
    void pop();
    T onTop() const;
    bool isEmpty() const;
    void clear();
private:
    struct Node
    {
        T value;
        Node *next;
        Node(T value);
        ~Node();
    } *top;
    static Stack::Node *copy(const Stack<T>::Node *otherTop);
};


template<typename T>
Stack<T>::Stack():
    top(nullptr)
{

}

template<typename T>
Stack<T>::Stack(const Stack &original):
    top(nullptr) //Конструктор копирования
{
    top = copy(original.top);
}

template<typename T>
Stack<T> &Stack<T>::operator=(const Stack &rhs) //Оператор копирующего присваивания
{
    Stack temp(rhs);
    swap(*this, temp);
    return *this;
}

template<typename T>
Stack<T>::Stack(Stack &&victim) :
    top(nullptr) //Конструктор перемещения
{
    swap(top, victim.top);
}

template<typename T>
Stack<T> &Stack<T>::operator=(Stack &&rhs) //Оператор переместительного присваивания
{
    swap(*this, rhs);
    return *this;
}

template<typename T>
Stack<T>::~Stack() //Деструктор
{
    clear();
}

template<typename T>
typename Stack<T>::Node *Stack<T>::copy(const Node *originalTop/*Указатель*/) //Функция
{
    Node *newTop = nullptr;
    Node *p = nullptr;
    const Node *q = originalTop;
    p = new Node(q->value);
    newTop = p;
    q = q->next;
    while (q != nullptr)
    {
        Node *r = nullptr;
        r = new Node(q->value);
        p->next = r;
        p = p->next;
        q = q->next;
    }
    return newTop;
}

template<typename T>
void Stack<T>::push(T value)
{
    Node *p = nullptr;
    p = new Node(value);
    p->next = top;
    top = p;
}

template<typename T>
void Stack<T>::pop()
{
    if (!isEmpty())
    {
        Node *p = top;
        top = top->next;
        delete p;
    }
}

template<typename T>
T Stack<T>::onTop() const
{
    if (isEmpty())
        throw exception();
    return top->value;
}

template<typename T>
bool Stack<T>::isEmpty()const
{
    return top == nullptr;
}

template<typename T>
void Stack<T>::clear()
{
    while (!isEmpty())
    {
        Node *p = top;
        top = top->next;
        delete p;
    }
}

template<typename T>
Stack<T>::Node::Node(T value):
    value(value),
    next(nullptr)
{

}

template<typename T>
Stack<T>::Node::~Node()
{
    next = nullptr;
}

#endif // STACK_H
