#ifndef IMPLEMENTATION_H
#define IMPLEMENTATION_H

#include "stack.h"

class Stack::Implementation
{
public:
    Implementation();
    Implementation(const Implementation &other);
    Implementation &operator =(const Implementation &other);
    Implementation(Implementation &&other);
    Implementation &operator =(Implementation &&other);
    ~Implementation();

    void push(Data data);
    void pop();
    Data onTop() const;
    bool isEmpty() const;
    void clear();

    void getArrayRepresentation(Data *&array, int &size)const;
    bool getNext(Data &data, bool firstTime)const;
    void acceptVisitor(void (*visitor)(Data))const;

private:
    struct Node
    {
        Data data;
        Node *next;
        Node(Data data);
        ~Node();
    } *top;
    static Node *copy(const Node *otherTop);
    static void leadVisitor(const Node *node,
                            void (*visitor)(Data));
};

#endif // IMPLEMENTATION_H
