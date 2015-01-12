#ifndef PREVIOUS_H
#define PREVIOUS_H

#include "term.h"

using namespace std;

class Previous: public Term
{
public:
    Previous() = default;
    Previous(const Previous &original) = default;
    Previous &operator=(const Previous &rhs) = default;
    Previous(Previous &&victim) = default;
    Previous &operator=(Previous &&rhs) = default;
    ~Previous() = default;

    void execute(Machine &machine, int &instruction) const override;
};

#endif // PREVIOUS_H
