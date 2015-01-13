#ifndef INC_H
#define INC_H

#include "term.h"

using namespace std;

class Inc: public Term
{
public:
    Inc() = default;
    Inc(const Inc &original) = default;
    Inc &operator=(const Inc &rhs) = default;
    Inc(Inc &&victim) = default;
    Inc &operator=(Inc &&rhs) = default;
    ~Inc() = default;

    void execute(Machine &machine, unsigned int &instruction) const override;
};

#endif // INC_H
