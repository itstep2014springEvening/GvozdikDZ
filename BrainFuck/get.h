#ifndef GET_H
#define GET_H

#include "term.h"

using namespace std;

class Get: public Term
{
public:
    Get() = default;
    Get(const Get &original) = default;
    Get &operator=(const Get &rhs) = default;
    Get(Get &&victim) = default;
    Get &operator=(Get &&rhs) = default;
    ~Get() = default;

    void execute(Machine &machine, int &instruction) const override;
};

#endif // GET_H
