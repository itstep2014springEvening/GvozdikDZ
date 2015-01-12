#ifndef NEXT_H
#define NEXT_H

#include "term.h"

using namespace std;

class Next: public Term
{
public:
    Next() = default;
    Next(const Next &original) = default;
    Next &operator=(const Next &rhs) = default;
    Next(Next &&victim) = default;
    Next &operator=(Next &&rhs) = default;
    ~Next() = default;

    void execute(Machine &machine, int &instruction) const override;
};

#endif // NEXT_H
