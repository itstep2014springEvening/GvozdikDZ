#ifndef IMPLEMENTATION_H
#define IMPLEMENTATION_H

#include "stack.h"

class Stack::Implementation
{
public:
    Implementation(); //Конструктор
    Implementation(const Implementation &original); //Конструктор копирования
    Implementation &operator=(const Implementation &rhs);  //Оператор присваивания
    Implementation(Implementation &&victim); //Конструктор перемещения
    Implementation &operator=(Implementation &&rhs); //Оператор переместительного присваивания
    ~Implementation(); //Деструктор

    void push(Data data);
    void pop();
    Data onTop() const;
    bool isEmpty() const;
    void clear();

    void getArrayRepresentation(Data *&array, int &size) const;
private:
    struct Node
    {
        Data data;
        Node *next;
        Node(Data data);
        ~Node();
    } *top;
    static Node *copy(const Node *otherTop);
};

#endif // IMPLEMENTATION_H
