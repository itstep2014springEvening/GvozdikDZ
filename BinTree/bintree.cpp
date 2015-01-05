#include "bintree.h"
#include <iostream>
#include <utility>

using namespace std;

BinTree::BinTree() : root(nullptr) //Конструктор
{

}
BinTree::BinTree(const BinTree &original) : root(nullptr)//Конструктор копирования
{
    root = clone(original.root);
}
BinTree &BinTree::operator=(const BinTree &rhs) //Оператор копирующего присваивания
{
    BinTree temp(rhs);
    swap(*this, temp);
    return *this;
}
BinTree::BinTree(BinTree &&victim) : root(nullptr)//Конструктор перемещения
{
    swap(root, victim.root);
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
        delete root;
        root = nullptr;
    }
}

bool BinTree::search(Data data) const
{
    if (!root)
    {
        return false;
    }
    else
    {
        Node *pointer = root;
        while (pointer)
        {
            if (data < pointer->data)
                pointer = pointer->left;
            else if (data > pointer->data)
                pointer = pointer->right;
            else
                return true;
        }
    }
    return false;
}
void BinTree::add(Data data)
{
    if (!root)
    {
        root = new Node(data);
    }
    else
    {
        Node *pointer = root, *parent = nullptr;
        while (pointer && pointer->data != data)
        {
            parent = pointer;
            if (data < pointer->data)
                pointer = pointer->left;
            else
                pointer = pointer->right;
        }
        pointer = new Node(data);
        if (pointer->data < parent->data)
            parent->left = pointer;
        else
            parent->right = pointer;
    }
}
void BinTree::remove(Data data)
{
    if (!root)
    {
        return;
    }
    else
    {
        Node *pointer = root, *parent = nullptr;
        while (pointer && pointer->data != data)
        {
            parent = pointer;
            if (data < pointer->data)
                pointer = pointer->left;
            else
                pointer = pointer->right;
        }
        if(pointer)
        {
            if(!pointer->left || !pointer->right)
            {
                Node *leaf = nullptr;
                if(pointer->left)
                    leaf = pointer->left;
                else if(pointer->right)
                    leaf = pointer->right;
                if(!parent)
                {
                    root = leaf;
                }
                else
                {
                    if(parent->left == pointer)
                        parent->left = leaf;
                    else
                        parent->right = leaf;
                }
            }
            else
            {
                Node *mostLeft = parent->right, *mostLeftParent = pointer;
                while(mostLeft->left)
                {
                    mostLeftParent = mostLeft;
                    mostLeft = mostLeft->left;
                }
                pointer->data = mostLeft->data;
                if(mostLeftParent->left == mostLeft)
                    mostLeftParent->left = nullptr;
                else
                    mostLeftParent->right = nullptr;
            }
        }
    }
}

BinTree::Node *BinTree::clone(BinTree::Node *node)
{
    Node *result = nullptr;
    if(node)
    {
        result = new Node(*node);
        result->data = node->data;
        result->left = clone(node->left);
        result->right = clone(node->right);
    }
    return result;
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
