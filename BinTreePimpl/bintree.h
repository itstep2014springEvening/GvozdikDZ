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

    bool search(Data data) const;
    void add(Data data);
    void remove(Data data);

protected:
    void getArrayRepresentation(Data *&array, int &size)const;
    bool getNext(Data &data, bool firstTime)const;
    void acceptVisitor(void (*visitor)(Data))const;

private:
    class Implementation;
    Implementation *pimpl;

};

#endif // BINTREE_H
