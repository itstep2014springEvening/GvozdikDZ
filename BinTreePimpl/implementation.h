#ifndef IMPLEMENTATION_H
#define IMPLEMENTATION_H

#include "bintree.h"

typedef int Data;

class BinTree::Implementation
{
public:
    Implementation(); //Конструктор
    Implementation(const Implementation &original); //Конструктор копирования
    Implementation &operator=(const Implementation &rhs);  //Оператор присваивания
    Implementation(Implementation &&victim); //Конструктор перемещения
    Implementation &operator=(Implementation &&rhs); //Оператор переместительного присваивания
    ~Implementation(); //Деструктор

    bool search(Data data) const;
    void add(Data data);
    void remove(Data data);

    void getArrayRepresentation(Data *&array, int &size)const;
    bool getNext(Data &data, bool firstTime)const;
    void acceptVisitor(void (*visitor)(Data))const;

private:
    struct Node
    {
        Data data;
        Node *right;
        Node *left;
        Node(Data data);
        ~Node();
    } *root;
    static Node *clone(Node *node);
    static void leadVisitor(const Node *node, void (*visitor)(Data));
};

#endif // IMPLEMENTATION_H
