#ifndef BINTREE_H
#define BINTREE_H

typedef int Data;

class BinTree
{
public:
    BinTree(); //Конструктор
    BinTree(const BinTree &original); //Конструктор копирования
    BinTree &operator=(const BinTree &rhs);  //Оператор присваивания
    BinTree(BinTree &&victim); //Конструктор перемещения
    BinTree &operator=(BinTree &&rhs); //Оператор переместительного присваивания
    ~BinTree(); //Деструктор

    bool find(Data data) const;
    void push(Data data);
    void pop(Data data);
    void output() const;
private:
    struct Node
    {
        Data data;
        Node *right;
        Node *left;
        Node(Data data);
        ~Node();
    } *root;
    static void output(Node *node);
};

#endif // BINTREE_H
