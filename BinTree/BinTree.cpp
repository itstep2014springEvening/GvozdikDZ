#include "bintree.h"
#include <iostream>
#include <utility>

using namespace std;

BinTree::BinTree() : root(nullptr) //Конструктор
{

}
BinTree::BinTree(const BinTree &original) : root(nullptr)//Конструктор копирования
{

}
BinTree &BinTree::operator=(const BinTree &rhs) //Оператор копирующего присваивания
{
    BinTree temp(rhs);
    swap(*this, temp);
    return *this;
}
BinTree::BinTree(BinTree &&victim) : root(nullptr)//Конструктор перемещения
{

}
BinTree &BinTree::operator=(BinTree &&rhs) //Оператор переместительного присваивания
{
    swap(*this, rhs);
    return *this;
}
BinTree::~BinTree() //Деструктор
{
    if (!root)
    {
        return;
    }
    else
    {
        pop(root->left->data);
        pop(root->right->data);
        delete root;
        root = nullptr;
    }
}

bool BinTree::find(Data data) const
{
    if (!root)
    {
        return false;
    }
    else
    {
        Node *q = root;
        while (q)
        {
            if (data < q->data)
                q = q->left;
            else if (data > q->data)
                q = q->right;
            else
                return true;
        }
    }
    return false;
}
void BinTree::push(Data data)
{
    if (!root)
    {
        root = new Node(data);
    }
    else
    {
        Node *q = root, *p = nullptr;
        while (q)
        {
            p = q;
            if (data < q->data)
                q = q->left;
            else if (data > q->data)
                q = q->right;
            else
                return;
        }
        q = new Node(data);
        if (q->data < p->data)
            p->left = q;
        else
            p->right = q;
    }
}
void BinTree::pop(Data data)
{
    if (!root)
    {
        return;
    }
    else
    {
        Node *q = root, *p = nullptr;
        while (q)
        {
            if (data = q->data)
            {

            }
        }
    }
}
void BinTree::output() const
{
    output(root);
}

void BinTree::output(Node *node)
{
    if (node)
    {
        output(node->left);
        cout << node->data << " ";
        output(node->right);
    }
}


BinTree::Node::Node(Data data) : data(data), right(nullptr), left(nullptr)
{

}

BinTree::Node::~Node()
{
    right = nullptr;
    left = nullptr;
}
