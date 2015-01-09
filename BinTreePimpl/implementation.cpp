#include "implementation.h"

#include <utility>
#include <exception>

using namespace std;

BinTree::Implementation::Implementation() : root(nullptr)
{

}

BinTree::Implementation::Implementation(const BinTree::Implementation &original) : root(nullptr)
{
    root = clone(original.root);
}

BinTree::Implementation &BinTree::Implementation::operator=(const BinTree::Implementation &rhs)
{
    Implementation temp(rhs);
    swap(*this, temp);
    return *this;
}

BinTree::Implementation::Implementation(BinTree::Implementation &&victim) : root(nullptr)
{
    swap(root, victim.root);
}

BinTree::Implementation &BinTree::Implementation::operator=(BinTree::Implementation &&rhs)
{
    swap(*this, rhs);
    return *this;
}

BinTree::Implementation::~Implementation()
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

bool BinTree::Implementation::search(Data data) const
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

void BinTree::Implementation::add(Data data)
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

void BinTree::Implementation::remove(Data data)
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

void BinTree::Implementation::getArrayRepresentation(Data *&array, int &size) const
{
    size = 0;
    Node *p = root;
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

bool BinTree::Implementation::getNext(Data &data, bool firstTime) const
{
    static Node *p;
    Node *q = root;
    bool result;
    if(firstTime)
    {
        p = q;
        while(q)
        {
            p = q;
            q = q->next;
        }
        result = p != nullptr;
    }
    else
    {
        while(q && q->next != p)
            q = q->next;
        result = q != nullptr;
        if(result)
            p = q;
    }
    if(result)
        data = p->data;
    return result;
}

void BinTree::Implementation::acceptVisitor(void (*visitor)(Data)) const
{
     leadVisitor(root, visitor);
}

BinTree::Implementation::Node *BinTree::Implementation::clone(BinTree::Implementation::Node *node)
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

void BinTree::Implementation::leadVisitor(const BinTree::Implementation::Node *node, void (*visitor)(Data))
{
    if (node)
    {
        leadVisitor(node->left, visitor);
        visitor(node->data);
        leadVisitor(node->right, visitor);
    }
}

BinTree::Implementation::Node::Node(Data data) : data(data), right(nullptr), left(nullptr)
{

}

BinTree::Implementation::Node::~Node()
{
    right = nullptr;
    left = nullptr;
}
