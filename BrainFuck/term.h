#ifndef TERM_H
#define TERM_H

#include "machine.h"

using namespace std;

class Term
{
public:
    Term() = default;
    Term(const Term &original) = default;
    Term &operator=(const Term &rhs) = default;
    Term(Term &&victim) = default;
    Term &operator=(Term &&rhs) = default;
    ~Term() = default;

    virtual void execute(Machine &machine, int &instruction) const = 0;
};

#endif // TERM_H
