#ifndef CONSOLEBINTREE_H
#define CONSOLEBINTREE_H


#include "bintree.h"


class ConsoleBinTree : public BinTree
{
public:
    ConsoleBinTree()=default;
    ConsoleBinTree(const ConsoleBinTree &)=default;
    ConsoleBinTree &operator=(const ConsoleBinTree &)=default;
    ConsoleBinTree(ConsoleBinTree &&)=default;
    ConsoleBinTree &operator=(ConsoleBinTree &&)=default;
    ~ConsoleBinTree()=default;

    void output()const;
private:
    virtual void outputImplementaion()const;
};

#endif // CONSOLEBINTREE_H
