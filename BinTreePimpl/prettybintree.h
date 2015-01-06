#ifndef PRETTYBINTREE_H
#define PRETTYBINTREE_H

#include "consolebintree.h"

class PrettyBinTree : public ConsoleBinTree
{
public:
    PrettyBinTree()=default;
    PrettyBinTree(const PrettyBinTree &)=default;
    PrettyBinTree &operator=(const PrettyBinTree &)=default;
    PrettyBinTree(PrettyBinTree &&)=default;
    PrettyBinTree &operator=(PrettyBinTree &&)=default;
    ~PrettyBinTree()=default;

private:
    void outputImplementaion()const override;
};

#endif // PRETTYBINTREE_H
